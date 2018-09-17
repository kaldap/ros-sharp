using System;
using System.Linq;
using System.Collections.Generic;

namespace RosMsgsGenerator
{
    class MainClass
    {
		public static string ReadAllOutput(string cmd, string args)
		{
			string o = null;
			using (System.Diagnostics.Process proc = new System.Diagnostics.Process())
			{
				proc.StartInfo.FileName = cmd;
				proc.StartInfo.Arguments = args;
				proc.StartInfo.UseShellExecute = false;
				proc.StartInfo.RedirectStandardOutput = true;
				proc.StartInfo.CreateNoWindow = true;
				proc.Start();
				o = proc.StandardOutput.ReadToEnd();
				proc.WaitForExit();
			}
			return o;
		}

        public static void Main(string[] args)
        {
			var newLine = new char[] { '\r', '\n' };

			Console.WriteLine("Reading list of messages...");
			var msgList = ReadAllOutput("rosmsg", "list").Split(newLine, StringSplitOptions.RemoveEmptyEntries);

			for (int i = 0; i < msgList.Length; i++)
			{
				Console.WriteLine("Generating message file {0}/{1} ({2})...", i + 1, msgList.Length, msgList[i]);
				var content = ReadAllOutput("rosmsg", "show -r " + msgList[i]).Split(newLine, StringSplitOptions.RemoveEmptyEntries);
				var msg = new MessageWriter(msgList[i]);
				msg.LoadFromMsg(content);
				msg.Save();
            }
        }
    }
}
