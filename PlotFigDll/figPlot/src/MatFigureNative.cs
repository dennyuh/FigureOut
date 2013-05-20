/*
* MATLAB Compiler: 4.13 (R2010a)
* Date: Fri May 17 17:53:09 2013
* Arguments: "-B" "macro_default" "-W" "dotnet:FigPlot,MatFigure,3.5," "-T" "link:lib"
* "-d" "E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\FigPlot\src" "-w"
* "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{MatFigure:E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\closeFig.
* m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\createFigHandle.m,E:\Den
* ny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\createText.m,E:\Denny'sPrograms\
* AutoFigureApp\AutoFigProMatlabDlls\PlotFig\deleteAllGraphics.m,E:\Denny'sPrograms\AutoFi
* gureApp\AutoFigProMatlabDlls\PlotFig\deleteAllText.m,E:\Denny'sPrograms\AutoFigureApp\Au
* toFigProMatlabDlls\PlotFig\figPlot.m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDl
* ls\PlotFig\setAxesProperty.m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotF
* ig\setFigureProperty.m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\set
* TextAccuracy.m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setTextProp
* erty.m,E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setXLabel.m,E:\Denn
* y'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setYLabel.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using MathWorks.MATLAB.NET.ComponentData;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace FigPlotNative
{
  /// <summary>
  /// The MatFigure class provides a CLS compliant, Object (native) interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\closeFig.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\createFigHandle.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\createText.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\deleteAllGraphics.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\deleteAllText.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\figPlot.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setAxesProperty.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setFigureProperty.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setTextAccuracy.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setTextProperty.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setXLabel.m
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\PlotFig\setYLabel.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 3.5
  /// </remarks>
  public class MatFigure : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static MatFigure()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_FigPlot_name_data + ".ctf";

        Stream embeddedCtfStream = null;

        String[] resourceStrings = assembly.GetManifestResourceNames();

        foreach (String name in resourceStrings)
        {
          if (name.Contains(ctfFileName))
          {
            embeddedCtfStream = assembly.GetManifestResourceStream(name);
            break;
          }
        }
        mcr= new MWMCR(MCRComponentState.MCC_FigPlot_name_data,
                       MCRComponentState.MCC_FigPlot_root_data,
                       MCRComponentState.MCC_FigPlot_public_data,
                       MCRComponentState.MCC_FigPlot_session_data,
                       MCRComponentState.MCC_FigPlot_matlabpath_data,
                       MCRComponentState.MCC_FigPlot_classpath_data,
                       MCRComponentState.MCC_FigPlot_libpath_data,
                       MCRComponentState.MCC_FigPlot_mcr_application_options,
                       MCRComponentState.MCC_FigPlot_mcr_runtime_options,
                       MCRComponentState.MCC_FigPlot_mcr_pref_dir,
                       MCRComponentState.MCC_FigPlot_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the MatFigure class.
    /// </summary>
    public MatFigure()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~MatFigure()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the closeFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void closeFig()
    {
      mcr.EvaluateFunction(0, "closeFig", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the closeFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] closeFig(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "closeFig", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the createFigHandle
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void createFigHandle()
    {
      mcr.EvaluateFunction(0, "createFigHandle", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the createFigHandle M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createFigHandle(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createFigHandle", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void createText()
    {
      mcr.EvaluateFunction(0, "createText", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void createText(Object x)
    {
      mcr.EvaluateFunction(0, "createText", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void createText(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "createText", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    ///
    public void createText(Object x, Object y, Object value)
    {
      mcr.EvaluateFunction(0, "createText", x, y, value);
    }


    /// <summary>
    /// Provides a void output, 4-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    ///
    public void createText(Object x, Object y, Object value, Object fsize)
    {
      mcr.EvaluateFunction(0, "createText", x, y, value, fsize);
    }


    /// <summary>
    /// Provides a void output, 5-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    ///
    public void createText(Object x, Object y, Object value, Object fsize, Object fname)
    {
      mcr.EvaluateFunction(0, "createText", x, y, value, fsize, fname);
    }


    /// <summary>
    /// Provides a void output, 6-input Objectinterface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <param name="t">Input argument #6</param>
    ///
    public void createText(Object x, Object y, Object value, Object fsize, Object fname, 
                     Object t)
    {
      mcr.EvaluateFunction(0, "createText", x, y, value, fsize, fname, t);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x, Object y, Object value)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x, y, value);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x, Object y, Object value, Object 
                         fsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x, y, value, fsize);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x, Object y, Object value, Object 
                         fsize, Object fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x, y, value, fsize, fname);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the createText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="value">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <param name="t">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] createText(int numArgsOut, Object x, Object y, Object value, Object 
                         fsize, Object fname, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "createText", x, y, value, fsize, fname, t);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the deleteAllGraphics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void deleteAllGraphics()
    {
      mcr.EvaluateFunction(0, "deleteAllGraphics", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the deleteAllGraphics
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] deleteAllGraphics(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "deleteAllGraphics", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the deleteAllText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void deleteAllText()
    {
      mcr.EvaluateFunction(0, "deleteAllText", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the deleteAllText M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] deleteAllText(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "deleteAllText", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void figPlot()
    {
      mcr.EvaluateFunction(0, "figPlot", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    ///
    public void figPlot(Object x)
    {
      mcr.EvaluateFunction(0, "figPlot", x);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    ///
    public void figPlot(Object x, Object y)
    {
      mcr.EvaluateFunction(0, "figPlot", x, y);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    ///
    public void figPlot(Object x, Object y, Object threshold)
    {
      mcr.EvaluateFunction(0, "figPlot", x, y, threshold);
    }


    /// <summary>
    /// Provides a void output, 4-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    ///
    public void figPlot(Object x, Object y, Object threshold, Object fsize)
    {
      mcr.EvaluateFunction(0, "figPlot", x, y, threshold, fsize);
    }


    /// <summary>
    /// Provides a void output, 5-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    ///
    public void figPlot(Object x, Object y, Object threshold, Object fsize, Object fname)
    {
      mcr.EvaluateFunction(0, "figPlot", x, y, threshold, fsize, fname);
    }


    /// <summary>
    /// Provides a void output, 6-input Objectinterface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <param name="t">Input argument #6</param>
    ///
    public void figPlot(Object x, Object y, Object threshold, Object fsize, Object fname, 
                  Object t)
    {
      mcr.EvaluateFunction(0, "figPlot", x, y, threshold, fsize, fname, t);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x, Object y)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x, y);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x, Object y, Object threshold)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x, y, threshold);
    }


    /// <summary>
    /// Provides the standard 4-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x, Object y, Object threshold, Object 
                      fsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x, y, threshold, fsize);
    }


    /// <summary>
    /// Provides the standard 5-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x, Object y, Object threshold, Object 
                      fsize, Object fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x, y, threshold, fsize, fname);
    }


    /// <summary>
    /// Provides the standard 6-input Object interface to the figPlot M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="x">Input argument #1</param>
    /// <param name="y">Input argument #2</param>
    /// <param name="threshold">Input argument #3</param>
    /// <param name="fsize">Input argument #4</param>
    /// <param name="fname">Input argument #5</param>
    /// <param name="t">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] figPlot(int numArgsOut, Object x, Object y, Object threshold, Object 
                      fsize, Object fname, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "figPlot", x, y, threshold, fsize, fname, t);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setAxesProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setAxesProperty()
    {
      mcr.EvaluateFunction(0, "setAxesProperty", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setAxesProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    ///
    public void setAxesProperty(Object ppName)
    {
      mcr.EvaluateFunction(0, "setAxesProperty", ppName);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the setAxesProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    ///
    public void setAxesProperty(Object ppName, Object ppValue)
    {
      mcr.EvaluateFunction(0, "setAxesProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setAxesProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setAxesProperty(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setAxesProperty", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setAxesProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setAxesProperty(int numArgsOut, Object ppName)
    {
      return mcr.EvaluateFunction(numArgsOut, "setAxesProperty", ppName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setAxesProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setAxesProperty(int numArgsOut, Object ppName, Object ppValue)
    {
      return mcr.EvaluateFunction(numArgsOut, "setAxesProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setFigureProperty()
    {
      mcr.EvaluateFunction(0, "setFigureProperty", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    ///
    public void setFigureProperty(Object ppName)
    {
      mcr.EvaluateFunction(0, "setFigureProperty", ppName);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    ///
    public void setFigureProperty(Object ppName, Object ppValue)
    {
      mcr.EvaluateFunction(0, "setFigureProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setFigureProperty(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setFigureProperty", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setFigureProperty(int numArgsOut, Object ppName)
    {
      return mcr.EvaluateFunction(numArgsOut, "setFigureProperty", ppName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setFigureProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setFigureProperty(int numArgsOut, Object ppName, Object ppValue)
    {
      return mcr.EvaluateFunction(numArgsOut, "setFigureProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setTextAccuracy
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setTextAccuracy()
    {
      mcr.EvaluateFunction(0, "setTextAccuracy", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setTextAccuracy
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="t">Input argument #1</param>
    ///
    public void setTextAccuracy(Object t)
    {
      mcr.EvaluateFunction(0, "setTextAccuracy", t);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setTextAccuracy M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setTextAccuracy(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setTextAccuracy", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setTextAccuracy M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="t">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setTextAccuracy(int numArgsOut, Object t)
    {
      return mcr.EvaluateFunction(numArgsOut, "setTextAccuracy", t);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setTextProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setTextProperty()
    {
      mcr.EvaluateFunction(0, "setTextProperty", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setTextProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    ///
    public void setTextProperty(Object ppName)
    {
      mcr.EvaluateFunction(0, "setTextProperty", ppName);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the setTextProperty
    /// M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    ///
    public void setTextProperty(Object ppName, Object ppValue)
    {
      mcr.EvaluateFunction(0, "setTextProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setTextProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setTextProperty(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setTextProperty", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setTextProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setTextProperty(int numArgsOut, Object ppName)
    {
      return mcr.EvaluateFunction(numArgsOut, "setTextProperty", ppName);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setTextProperty M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="ppName">Input argument #1</param>
    /// <param name="ppValue">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setTextProperty(int numArgsOut, Object ppName, Object ppValue)
    {
      return mcr.EvaluateFunction(numArgsOut, "setTextProperty", ppName, ppValue);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setXLabel()
    {
      mcr.EvaluateFunction(0, "setXLabel", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    ///
    public void setXLabel(Object labelname)
    {
      mcr.EvaluateFunction(0, "setXLabel", labelname);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    ///
    public void setXLabel(Object labelname, Object fname)
    {
      mcr.EvaluateFunction(0, "setXLabel", labelname, fname);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <param name="fsize">Input argument #3</param>
    ///
    public void setXLabel(Object labelname, Object fname, Object fsize)
    {
      mcr.EvaluateFunction(0, "setXLabel", labelname, fname, fsize);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setXLabel(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setXLabel", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setXLabel(int numArgsOut, Object labelname)
    {
      return mcr.EvaluateFunction(numArgsOut, "setXLabel", labelname);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setXLabel(int numArgsOut, Object labelname, Object fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "setXLabel", labelname, fname);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the setXLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <param name="fsize">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setXLabel(int numArgsOut, Object labelname, Object fname, Object 
                        fsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "setXLabel", labelname, fname, fsize);
    }


    /// <summary>
    /// Provides a void output, 0-input Objectinterface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void setYLabel()
    {
      mcr.EvaluateFunction(0, "setYLabel", new Object[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input Objectinterface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    ///
    public void setYLabel(Object labelname)
    {
      mcr.EvaluateFunction(0, "setYLabel", labelname);
    }


    /// <summary>
    /// Provides a void output, 2-input Objectinterface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    ///
    public void setYLabel(Object labelname, Object fname)
    {
      mcr.EvaluateFunction(0, "setYLabel", labelname, fname);
    }


    /// <summary>
    /// Provides a void output, 3-input Objectinterface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <param name="fsize">Input argument #3</param>
    ///
    public void setYLabel(Object labelname, Object fname, Object fsize)
    {
      mcr.EvaluateFunction(0, "setYLabel", labelname, fname, fsize);
    }


    /// <summary>
    /// Provides the standard 0-input Object interface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setYLabel(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "setYLabel", new Object[]{});
    }


    /// <summary>
    /// Provides the standard 1-input Object interface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setYLabel(int numArgsOut, Object labelname)
    {
      return mcr.EvaluateFunction(numArgsOut, "setYLabel", labelname);
    }


    /// <summary>
    /// Provides the standard 2-input Object interface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setYLabel(int numArgsOut, Object labelname, Object fname)
    {
      return mcr.EvaluateFunction(numArgsOut, "setYLabel", labelname, fname);
    }


    /// <summary>
    /// Provides the standard 3-input Object interface to the setYLabel M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="labelname">Input argument #1</param>
    /// <param name="fname">Input argument #2</param>
    /// <param name="fsize">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public Object[] setYLabel(int numArgsOut, Object labelname, Object fname, Object 
                        fsize)
    {
      return mcr.EvaluateFunction(numArgsOut, "setYLabel", labelname, fname, fsize);
    }


    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
