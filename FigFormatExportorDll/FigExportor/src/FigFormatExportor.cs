/*
* MATLAB Compiler: 4.13 (R2010a)
* Date: Thu May 16 15:57:48 2013
* Arguments: "-B" "macro_default" "-W" "dotnet:FigExportor,FigFormatExportor,3.5," "-T"
* "link:lib" "-d"
* "E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\FigFormatExportor\FigExportor\src
* " "-w" "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
* "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w" "enable:demo_license"
* "-v"
* "class{FigFormatExportor:E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\FigFormat
* Exportor\SaveFig.m}" 
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

namespace FigExportor
{
  /// <summary>
  /// The FigFormatExportor class provides a CLS compliant, MWArray interface to the
  /// M-functions contained in the files:
  /// <newpara></newpara>
  /// E:\Denny'sPrograms\AutoFigureApp\AutoFigProMatlabDlls\FigFormatExportor\SaveFig.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 3.5
  /// </remarks>
  public class FigFormatExportor : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static FigFormatExportor()
    {
      if (MWMCR.MCRAppInitialized)
      {
        Assembly assembly= Assembly.GetExecutingAssembly();

        string ctfFilePath= assembly.Location;

        int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

        ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

        string ctfFileName = MCRComponentState.MCC_FigExportor_name_data + ".ctf";

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
        mcr= new MWMCR(MCRComponentState.MCC_FigExportor_name_data,
                       MCRComponentState.MCC_FigExportor_root_data,
                       MCRComponentState.MCC_FigExportor_public_data,
                       MCRComponentState.MCC_FigExportor_session_data,
                       MCRComponentState.MCC_FigExportor_matlabpath_data,
                       MCRComponentState.MCC_FigExportor_classpath_data,
                       MCRComponentState.MCC_FigExportor_libpath_data,
                       MCRComponentState.MCC_FigExportor_mcr_application_options,
                       MCRComponentState.MCC_FigExportor_mcr_runtime_options,
                       MCRComponentState.MCC_FigExportor_mcr_pref_dir,
                       MCRComponentState.MCC_FigExportor_set_warning_state,
                       ctfFilePath, embeddedCtfStream, true);
      }
      else
      {
        throw new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the FigFormatExportor class.
    /// </summary>
    public FigFormatExportor()
    {
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~FigFormatExportor()
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
    /// Provides a void output, 0-input MWArrayinterface to the SaveFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    ///
    public void SaveFig()
    {
      mcr.EvaluateFunction(0, "SaveFig", new MWArray[]{});
    }


    /// <summary>
    /// Provides a void output, 1-input MWArrayinterface to the SaveFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="targetfn">Input argument #1</param>
    ///
    public void SaveFig(MWArray targetfn)
    {
      mcr.EvaluateFunction(0, "SaveFig", targetfn);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the SaveFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SaveFig(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "SaveFig", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the SaveFig M-function.
    /// </summary>
    /// <remarks>
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="targetfn">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] SaveFig(int numArgsOut, MWArray targetfn)
    {
      return mcr.EvaluateFunction(numArgsOut, "SaveFig", targetfn);
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
