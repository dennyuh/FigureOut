using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Text;
using System.Xml;
using FigPlot;
using MathWorks.MATLAB.NET.Arrays;
//using MathWorks.MATLAB.NET.Utility;
using System.Text.RegularExpressions;
using FigExportor;

namespace AutoFigPro
{
    public partial class Form1 : Form
    {
        private String strSingleFilename;
        private String strSingleTargetFilename;
        private String strSourceData;
        private DataParse ParseInst;
        private InstalledFontCollection fonts;
        private readonly string defaultProfilename = "DefaultParams.xml";
        private readonly string appPath = Directory.GetCurrentDirectory();
        private MatFigure matFig;
        private FigFormatExportor matExportor;
        private string lastValidXFontSize;
        private string lastValidYFontSize;
        private string lastValidCurveFontSize;
        private string lastValidCutOffPercentage;
        public Form1()
        {
            try
            {
                matFig = new MatFigure();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            try
            {
                matExportor = new FigFormatExportor();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            InitializeComponent();
            ParseInst = new DataParse();
            fonts = new InstalledFontCollection();
            foreach (FontFamily family in fonts.Families)
            {
                comboSingleXFont.Items.Add(family.Name);
                comboSingleYFont.Items.Add(family.Name);
                comboCurveTextFont.Items.Add(family.Name);
            }
            // Create matlab figure handle
            matFig.createFigHandle();
            // Load default parameters from profile
            Directory.SetCurrentDirectory(appPath);
            setParametersFormProfile(defaultProfilename);
            lastValidXFontSize = textXFontSize.Text.Trim();
            lastValidYFontSize = textYFontSize.Text.Trim();
            lastValidCurveFontSize = textCurveTextFontSize.Text.Trim();
            lastValidCutOffPercentage = textCutOff.Text.Trim();
        }

        private void setParametersFormProfile(string filename)
        {
            XmlReader rdr = XmlReader.Create(filename);
            while (rdr.Read())
            {
                if (rdr.MoveToContent() == XmlNodeType.Element && rdr.AttributeCount == 2)
                {
                    string controlName = rdr.GetAttribute(0);
                    string controlValue = rdr.GetAttribute(1);
                    if (rdr.Name == "ControlText")
                        Controls.Find(controlName, true)[0].Text = controlValue;
                    else if (rdr.Name == "ControlCheck")
                        ((CheckBox) Controls.Find(controlName, true)[0]).Checked = controlValue == "true" ? true : false;
                }
            }
            rdr.Close();
        }

        private void saveProfile(string filename)
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.NewLineOnAttributes = true;
            XmlWriter writer = XmlWriter.Create(filename, settings);
            writer.WriteStartDocument();
                //axis parameters
            writer.WriteStartElement("Parameters");
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textSingleXLabel.Name);
                    writer.WriteAttributeString("Value", textSingleXLabel.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textSingleYLabel.Name);
                    writer.WriteAttributeString("Value", textSingleYLabel.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboSingleXFont.Name);
                    writer.WriteAttributeString("Value", comboSingleYFont.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboSingleYFont.Name);
                    writer.WriteAttributeString("Value", comboSingleYFont.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkSingleXBold.Name);
                    writer.WriteAttributeString("Value", checkSingleXBold.Checked==true?"true":"false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkSingleYBold.Name);
                    writer.WriteAttributeString("Value", checkSingleYBold.Checked == true ? "true" : "false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkSingleXItalic.Name);
                    writer.WriteAttributeString("Value", checkSingleXItalic.Checked == true ? "true" : "false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkSingleYItalic.Name);
                    writer.WriteAttributeString("Value", checkSingleYItalic.Checked == true ? "true" : "false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textXFontSize.Name);
                    writer.WriteAttributeString("Value", textXFontSize.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textYFontSize.Name);
                    writer.WriteAttributeString("Value", textYFontSize.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboYValue.Name);
                    writer.WriteAttributeString("Value", comboYValue.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textXFontSize.Name);
                    writer.WriteAttributeString("Value", textXFontSize.Text);
                writer.WriteEndElement();
                //curve parameters
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboCurveTextFont.Name);
                    writer.WriteAttributeString("Value", comboCurveTextFont.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkCurveTextBold.Name);
                    writer.WriteAttributeString("Value", checkCurveTextBold.Checked == true ? "true" : "false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlCheck");
                    writer.WriteAttributeString("Name", checkCurveTextItalic.Name);
                    writer.WriteAttributeString("Value", checkCurveTextItalic.Checked == true ? "true" : "false");
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textCurveTextFontSize.Name);
                    writer.WriteAttributeString("Value", textCurveTextFontSize.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboCurveTextDir.Name);
                    writer.WriteAttributeString("Value", comboCurveTextDir.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", textCutOff.Name);
                    writer.WriteAttributeString("Value", textCutOff.Text);
                writer.WriteEndElement();
                writer.WriteStartElement("ControlText");
                    writer.WriteAttributeString("Name", comboAccuracy.Name);
                    writer.WriteAttributeString("Value", comboAccuracy.Text);
                writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

        private void radioSingleFromClipboard_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton) sender).Checked)
            {
                butSinglePaste.Enabled = true;
                butSingleSourceBrowse.Enabled = false;
                textSingleSourceFile.Enabled = false;
            }
        }

        private void radioSingleSourceFile_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton) sender).Checked)
            {
                butSingleSourceBrowse.Enabled = true;
                textSingleSourceFile.Enabled = true;
                butSinglePaste.Enabled = false;
            }
        }

        private void butSingleSourceBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = appPath;
            openFileDlg.Filter = "text file (*.txt)|*.txt";
            openFileDlg.RestoreDirectory = true;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                strSingleFilename = openFileDlg.FileName;
                textSingleSourceFile.Text = strSingleFilename;
                StreamReader sr = new StreamReader(textSingleSourceFile.Text);
                ParseInst.StrSourceData = sr.ReadToEnd();
                ParseInst.Parse();
                updateFigure();
            }
        }

        private void updateTextOnFigure()
        {
            
        }

        private void updateFigure()
        {
            if (comboYValue.Text == "Percentage" && ParseInst.Good)
            {
                matFig.deleteAllGraphics();
                matFig.figPlot((MWNumericArray) ParseInst.XData.ToArray(),
                               (MWNumericArray) ParseInst.YPercentageData.ToArray(),
                               (MWNumericArray) Convert.ToDouble(textCutOff.Text.Trim()),
                               (MWNumericArray) Convert.ToDouble(textCurveTextFontSize.Text.Trim()),
                               comboCurveTextFont.Text,
                               (MWNumericArray) Convert.ToInt16(comboAccuracy.Text));
                updateTextOnFigure();
            }
            else if (comboYValue.Text == "Absolute value" && ParseInst.Good)
            {
                matFig.deleteAllGraphics();
                matFig.figPlot((MWNumericArray)ParseInst.XData.ToArray(),
                               (MWNumericArray)ParseInst.YData.ToArray(),
                               (MWNumericArray)Convert.ToDouble(textCutOff.Text.Trim()),
                               (MWNumericArray)Convert.ToDouble(textCurveTextFontSize.Text.Trim()),
                               comboCurveTextFont.Text,
                               (MWNumericArray)Convert.ToInt16(comboAccuracy.Text));
                updateTextOnFigure();
            }
        }

        private void butSingleTargetBrowse_Click(object sender, EventArgs e)
        {
            SaveFileDialog savFileDlg = new SaveFileDialog();
            savFileDlg.InitialDirectory = appPath;
            savFileDlg.Filter = "Adobe Illustrator file (*.ai)|*.ai|Encapsulated PostScript file (*.eps)|*.eps";
            savFileDlg.RestoreDirectory = true;
            if (savFileDlg.ShowDialog() == DialogResult.OK)
            {
                strSingleTargetFilename = savFileDlg.FileName;
                textSingleTargetFile.Text = strSingleTargetFilename;
            }
        }

        private void butSinglePaste_Click(object sender, EventArgs e)
        {
            IDataObject dataHandle = Clipboard.GetDataObject();
            if (dataHandle.GetDataPresent(DataFormats.Text))
            {
                strSourceData = (String) dataHandle.GetData(DataFormats.Text);
                ParseInst.StrSourceData = strSourceData;
                ParseInst.Parse();
                updateFigure();
            }
        }

        private void butSingleSave_Click(object sender, EventArgs e)
        {
            if (textSingleTargetFile.Text != "")
            {
                try
                {
                    matExportor.SaveFig(textSingleTargetFile.Text);
                    MessageBox.Show("File saved successfully!");
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.ToString());
                }
            }
            else
            {
                MessageBox.Show("Please select target file");
            }
        }

        private void butSaveProfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog savFileDlg = new SaveFileDialog();
            savFileDlg.InitialDirectory = appPath;
            savFileDlg.Filter = "XML file (*.xml)|*.xml";
            savFileDlg.RestoreDirectory = true;
            if (savFileDlg.ShowDialog() == DialogResult.OK)
            {
                saveProfile(savFileDlg.FileName);
            }
        }

        private void comboCurveTextDir_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            matFig.closeFig();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            matFig.setFigureProperty("Visible", "on");
        }

        private void butLoadProfile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDlg = new OpenFileDialog();
            openFileDlg.InitialDirectory = appPath;
            openFileDlg.Filter = "XML file (*.xml)|*.xml";
            openFileDlg.RestoreDirectory = true;
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                setParametersFormProfile(openFileDlg.FileName);
            }
        }

        private bool isValidDecimal(string strIn)
        {
            return Regex.IsMatch(strIn, @"^(\d+)(\.\d+)?$");
        }

        private void textSingleXLabel_TextChanged(object sender, EventArgs e)
        {
            setXLabel();
        }

        private void comboSingleXFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            setXLabel();
        }

        private void checkSingleXBold_CheckedChanged(object sender, EventArgs e)
        {
            setXLabel();
        }

        private void checkSingleXItalic_CheckedChanged(object sender, EventArgs e)
        {
            setXLabel();
        }

        private void textXFontSize_TextChanged(object sender, EventArgs e)
        {
            if (isValidDecimal(textXFontSize.Text.Trim()))
                setXLabel();
        }

        private void setXLabel()
        {
            string prefix = String.Format("{0}{1}", checkSingleXBold.Checked == true ? @"\bf" : "", checkSingleXItalic.Checked == true ? @"\it" : "");
            try
            {
                matFig.setXLabel(prefix + textSingleXLabel.Text, comboSingleXFont.Text, (MWNumericArray)Convert.ToDouble(textXFontSize.Text.Trim()));
            }
            catch (FormatException e)
            {
                //do nothing;
            }
        }

        private void textXFontSize_Leave(object sender, EventArgs e)
        {
            if (isValidDecimal(textXFontSize.Text.Trim()))
            {
                lastValidXFontSize = textXFontSize.Text.Trim();
                setXLabel();
            }
            else
            {
                textXFontSize.Text = lastValidXFontSize;
                setXLabel();
            }
        }

        private void textXFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isValidDecimal(textXFontSize.Text.Trim()))
                {
                    lastValidXFontSize = textXFontSize.Text.Trim();
                    setXLabel();
                }
                else
                {
                    textXFontSize.Text = lastValidXFontSize;
                    setXLabel();
                }
            }
        }

        private void setYLabel()
        {
            string prefix = String.Format("{0}{1}", checkSingleYBold.Checked == true ? @"\bf" : "", checkSingleYItalic.Checked == true ? @"\it" : "");
            try
            {
                matFig.setYLabel(prefix + textSingleYLabel.Text, comboSingleYFont.Text, (MWNumericArray)Convert.ToDouble(textYFontSize.Text.Trim()));
            }
            catch (FormatException e)
            {
                //do nothing;
            }
        }

        private void textYFontSize_TextChanged(object sender, EventArgs e)
        {
            if (isValidDecimal(textXFontSize.Text.Trim()))
                setYLabel();
        }

        private void textYFontSize_Leave(object sender, EventArgs e)
        {
            if (isValidDecimal(textYFontSize.Text.Trim()))
            {
                lastValidYFontSize = textYFontSize.Text.Trim();
                setYLabel();
            }
            else
            {
                textYFontSize.Text = lastValidYFontSize;
                setYLabel();
            }
        }

        private void textYFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isValidDecimal(textYFontSize.Text.Trim()))
                {
                    lastValidYFontSize = textYFontSize.Text.Trim();
                    setYLabel();
                }
                else
                {
                    textYFontSize.Text = lastValidYFontSize;
                    setYLabel();
                }
            }
        }

        private void comboSingleYFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            setYLabel();
        }

        private void checkSingleYBold_CheckedChanged(object sender, EventArgs e)
        {
            setYLabel();
        }

        private void checkSingleYItalic_CheckedChanged(object sender, EventArgs e)
        {
            setYLabel();
        }

        private void comboCurveTextFont_SelectedIndexChanged(object sender, EventArgs e)
        {
            matFig.setTextProperty("FontName", comboCurveTextFont.Text);
        }

        private void checkCurveTextBold_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCurveTextBold.Checked)
                matFig.setTextProperty("FontWeight", "Bold");
            else
                matFig.setTextProperty("FontWeight", "Normal");
        }

        private void checkCurveTextItalic_CheckedChanged(object sender, EventArgs e)
        {
            if (checkCurveTextItalic.Checked)
                matFig.setTextProperty("FontAngle", "Italic");
            else
                matFig.setTextProperty("FontAngle", "Normal");
        }

        private void textCurveTextFontSize_TextChanged(object sender, EventArgs e)
        {
            if (isValidDecimal(textCurveTextFontSize.Text.Trim()))
                matFig.setTextProperty("FontSize", (MWNumericArray) Convert.ToDouble(textCurveTextFontSize.Text.Trim()));
        }

        private void textCurveTextFontSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isValidDecimal(textCurveTextFontSize.Text.Trim()))
                {
                    lastValidCurveFontSize = textCurveTextFontSize.Text.Trim();
                    matFig.setTextProperty("FontSize", (MWNumericArray) Convert.ToDouble(lastValidCurveFontSize));
                }
                else
                {
                    textCurveTextFontSize.Text = lastValidCurveFontSize;
                    matFig.setTextProperty("FontSize", (MWNumericArray) Convert.ToDouble(lastValidCurveFontSize));
                }
            }
        }

        private void textCurveTextFontSize_Leave(object sender, EventArgs e)
        {
            if (isValidDecimal(textCurveTextFontSize.Text.Trim()))
            {
                lastValidCurveFontSize = textCurveTextFontSize.Text.Trim();
                matFig.setTextProperty("FontSize", (MWNumericArray)Convert.ToDouble(lastValidCurveFontSize));
            }
            else
            {
                textCurveTextFontSize.Text = lastValidCurveFontSize;
                matFig.setTextProperty("FontSize", (MWNumericArray)Convert.ToDouble(lastValidCurveFontSize));
            }
        }

        private bool isValidPercentage(string strIn)
        {
            return (isValidDecimal(strIn) && Convert.ToDouble(strIn) >= 0 && Convert.ToDouble(strIn) <= 100);
        }

        private void textCutOff_TextChanged(object sender, EventArgs e)
        {
            if (isValidPercentage(textCutOff.Text.Trim()))
            {
                updateFigure();
            }
        }

        private void textCutOff_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (isValidPercentage(textCutOff.Text.Trim()))
                {
                    lastValidCutOffPercentage = textCutOff.Text.Trim();
                    updateFigure();
                }
                else
                {
                    textCutOff.Text = lastValidCutOffPercentage;
                    updateFigure();
                }
            }
        }

        private void textCutOff_Leave(object sender, EventArgs e)
        {
            if (isValidPercentage(textCutOff.Text.Trim()))
            {
                lastValidCutOffPercentage = textCutOff.Text.Trim();
                updateFigure();
            }
            else
            {
                textCutOff.Text = lastValidCutOffPercentage;
                updateFigure();
            }
        }

        private void comboYValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            updateFigure();
        }

        private void comboAccuracy_SelectedIndexChanged(object sender, EventArgs e)
        {
            matFig.setTextAccuracy((MWNumericArray) Convert.ToInt16(comboAccuracy.Text));
        }

        private void textSingleYLabel_TextChanged(object sender, EventArgs e)
        {
            setYLabel();
        }

        private void radioSingleProcessing_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                groupSingle.Enabled = true;
                groupBatch.Enabled = false;
            }
        }

        private void radioBatchProcessing_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                groupSingle.Enabled = false;
                matFig.closeFig();
                groupBatch.Enabled = true;
            }
        }
    }
}
