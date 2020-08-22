using AssemblySoft.DevOps;
using AssemblySoft.DevOps.Common;
using AssemblySoft.ProcessRunner;
using System;
using System.IO;
using System.Threading.Tasks;


namespace Setup.ComScire
{
    public class ActiveXTasks : NotifyTask
    {
        /// <summary>
        /// Sets the user environment variables 
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> SetEnvVars(string rootPath)
        {           

            RaiseOutputEvent(string.Format("Add user env variables: {0}", Settings.COMSCIRE_SETUP_ENV_SCRIPT));
            var args = rootPath;

            var procRunner = new ProcessRunner();
            procRunner.ProcessOutputData += (s, e) => //subscribe to notification event
            {
                RaiseOutputEvent(e.Message); //pass back to task runner
            };

            try
            {
                //run the script
                var fullPath = Path.Combine(rootPath, Constants.SCRIPTS, Settings.COMSCIRE_SETUP_ENV_SCRIPT);

                if (!File.Exists(fullPath))
                {
                    RaiseOutputEvent(string.Format("Unable to find the environment script to run {0}",fullPath));
                    return DevOpsTaskStatus.Terminated;
                }
                
                RaiseOutputEvent(string.Format("full path of the batch script: {0}", fullPath));

                var result = procRunner.RunProcess(Path.Combine(rootPath, Constants.SCRIPTS), Settings.COMSCIRE_SETUP_ENV_SCRIPT, args, useShellExecute: false, createNoWindow: false);
                                
            }
            catch (Exception e)
            {
                RaiseOutputEvent(e.Message);
                return DevOpsTaskStatus.Faulted;
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Copies activex dll based on environment configured source and destination locations
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Copy64BitDllEnv(string rootPath)
        {
            var args = string.Empty;

            try
            {
                var sourcePath = Path.Combine(rootPath, Constants.ASSETS, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_64_BIT_RELATIVE_SOURCE_DIR, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));                             

                var destDir = Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_32_BIT_DESTINATION, EnvironmentVariableTarget.User);
                var destPath = Path.Combine(destDir, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));
                
                if(!File.Exists(sourcePath))
                {
                    RaiseOutputEvent(string.Format("Source path {0} is invalid.", sourcePath));
                    return DevOpsTaskStatus.Terminated;
                }

                if(!Directory.Exists(destDir))
                {
                    RaiseOutputEvent(string.Format("Destination path {0} is invalid.", destDir));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("Copy 64bit dll from: {0} to: {1}", sourcePath, destPath));
                File.Copy(sourcePath,destPath, true);
            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch(Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Copies activex dll based on environment configured source and destination locations
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Copy32BitDllEnv(string rootPath)
        {
            try
            {
                var sourcePath = Path.Combine(rootPath, Constants.ASSETS, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_32_BIT_RELATIVE_SOURCE_DIR, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));                               


                var destDir = Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_64_BIT_DESTINATION, EnvironmentVariableTarget.User);
                var destPath = Path.Combine(destDir, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));

                if (!File.Exists(sourcePath))
                {
                    RaiseOutputEvent(string.Format("Source path {0} is invalid.", sourcePath));
                    return DevOpsTaskStatus.Terminated;
                }

                if (!Directory.Exists(destDir))
                {
                    RaiseOutputEvent(string.Format("Destination path {0} is invalid.", destDir));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("Copy 32bit dll from: {0} to: {1}", sourcePath, destPath));
                File.Copy(sourcePath, destPath, true);
            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch (Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Copies dependent dll based on environment configured source and destination locations
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Copy32BitFTDIDllEnv(string rootPath)
        {
            try
            {
                var sourcePath = Path.Combine(rootPath, Constants.ASSETS, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_32_BIT_RELATIVE_SOURCE_DIR, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.USB_DRIVER_FTDI_DLL, EnvironmentVariableTarget.User));
                
                var destDir = Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_64_BIT_DESTINATION, EnvironmentVariableTarget.User);
                var destPath = Path.Combine(destDir, Environment.GetEnvironmentVariable(EnvVars.USB_DRIVER_FTDI_DLL, EnvironmentVariableTarget.User));

                if (!File.Exists(sourcePath))
                {
                    RaiseOutputEvent(string.Format("Source path {0} is invalid.", sourcePath));
                    return DevOpsTaskStatus.Terminated;
                }

                if (!Directory.Exists(destDir))
                {
                    RaiseOutputEvent(string.Format("Destination path {0} is invalid.", destDir));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("Copy 32bit dll from: {0} to: {1}", sourcePath, destPath));
                File.Copy(sourcePath, destPath, true);
            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch (Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Copies dependent dll based on environment configured source and destination locations
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Copy64BitFTDIDllEnv(string rootPath)
        {
            try
            {
                var sourcePath = Path.Combine(rootPath, Constants.ASSETS, Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_64_BIT_RELATIVE_SOURCE_DIR, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.USB_DRIVER_FTDI_DLL, EnvironmentVariableTarget.User));
                
                var destDir = Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_32_BIT_DESTINATION, EnvironmentVariableTarget.User);
                var destPath = Path.Combine(destDir, Environment.GetEnvironmentVariable(EnvVars.USB_DRIVER_FTDI_DLL, EnvironmentVariableTarget.User));

                if (!File.Exists(sourcePath))
                {
                    RaiseOutputEvent(string.Format("Source path {0} is invalid.", sourcePath));
                    return DevOpsTaskStatus.Terminated;
                }

                if (!Directory.Exists(destDir))
                {
                    RaiseOutputEvent(string.Format("Destination path {0} is invalid.", destDir));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("Copy 32bit dll from: {0} to: {1}", sourcePath, destPath));
                File.Copy(sourcePath, destPath, true);
            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch (Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Registers a 64 bit DLL
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Register64BitDll(string rootPath)
        {
            var args = Path.Combine(Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_32_BIT_DESTINATION, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));
                   
            if (!File.Exists(args))
            {
                RaiseOutputEvent(string.Format("Source path {0} is invalid.", args));
                return DevOpsTaskStatus.Terminated;
            };

            RaiseOutputEvent(string.Format("Register ActiveX DLL: {0}", args));
         
            var procRunner = new ProcessRunner();
            procRunner.ProcessOutputData += (s, e) => //subscribe to notification event
            {
                RaiseOutputEvent(e.Message); //pass back to task runner
            };

            try
            {
                //run the script
                var fullPath = Path.Combine(rootPath, Constants.SCRIPTS, Settings.RegisterDll);

                if (!File.Exists(fullPath))
                {
                    RaiseOutputEvent(string.Format("Unable to find the environment script to run {0}", fullPath));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("full path of the batch script: {0}", fullPath));

                var result = procRunner.RunProcess(fullPath, args, useShellExecute: false, createNoWindow: false);

            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch (Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }

        /// <summary>
        /// Registers a 32 bit DLL
        /// </summary>
        /// <param name="rootPath"></param>
        /// <returns></returns>
        public async Task<DevOpsTaskStatus> Register32BitDll(string rootPath)
        {
            var args = Path.Combine(Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_64_BIT_DESTINATION, EnvironmentVariableTarget.User), Environment.GetEnvironmentVariable(EnvVars.COMSCIRE_ACTIVEX, EnvironmentVariableTarget.User));

            if (!File.Exists(args))
            {
                RaiseOutputEvent(string.Format("Source path {0} is invalid.", args));
                return DevOpsTaskStatus.Terminated;
            };

            RaiseOutputEvent(string.Format("Register ActiveX DLL: {0}", args));

            var procRunner = new ProcessRunner();
            procRunner.ProcessOutputData += (s, e) => //subscribe to notification event
            {
                RaiseOutputEvent(e.Message); //pass back to task runner
            };

            try
            {
                //run the script
                var fullPath = Path.Combine(rootPath, Constants.SCRIPTS, Settings.RegisterDll);

                if (!File.Exists(fullPath))
                {
                    RaiseOutputEvent(string.Format("Unable to find the environment script to run {0}", fullPath));
                    return DevOpsTaskStatus.Terminated;
                }

                RaiseOutputEvent(string.Format("full path of the batch script: {0}", fullPath));

                var result = procRunner.RunProcess(fullPath, args, useShellExecute: false, createNoWindow: false);

            }
            catch (IOException e)
            {
                RaiseOutputEvent(string.Format("An IO error has occured: {0}", e.Message));
                return DevOpsTaskStatus.Terminated;
            }
            catch (Exception e)
            {
                RaiseOutputEvent(string.Format("An unexpected error has occured: {0}", e.Message));
            }

            return DevOpsTaskStatus.Completed;
        }
       
    }
}
