using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text;

namespace Asp.Net_Core_5_Demo.Helpers
{
	public class FileUploadHelper
	{
		public static string UploadToPath { get; set; }

		public static byte[] UploadedBinaryData { get; set; }

		public static bool UploadFile(IFormFile uploadedFile)
		{
			if (uploadedFile != null && uploadedFile.Length > 0)
			{
				string baseAppFolder = System.AppDomain.CurrentDomain.BaseDirectory;
				string compinedSavePath = Path.Combine(baseAppFolder + @"Content\UploadedFiles\",
					Guid.NewGuid().ToString() + Path.GetExtension(uploadedFile.FileName));
				FileStream stream = new FileStream(compinedSavePath, FileMode.Create, FileAccess.Read);
				BinaryReader reader = new BinaryReader(stream, encoding: Encoding.UTF8, false);
				// Reading binary data from uploaded file
				byte[] fileData = reader.ReadBytes((Int32)stream.Length);
				// Assigning photos properties values from the provided parameters
				UploadToPath = compinedSavePath;
				UploadedBinaryData = fileData;
				uploadedFile.CopyTo(stream);
				reader.Dispose();
				stream.Dispose();

				return true;
			}
			else
			{
				return false;
			}
		}
	}
}