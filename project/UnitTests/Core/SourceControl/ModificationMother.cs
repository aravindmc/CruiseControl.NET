using System;

namespace ThoughtWorks.CruiseControl.Core.Sourcecontrol.Test
{
	public class ModificationMother
	{
		public static Modification CreateModification(
			string fileName,
			string folderName,
			DateTime modifiedTime,
			string userName,
			string comment,
			int changeNumber,
			string emailAddress,
			string url)
		{
			Modification mod = new Modification();
			
			mod.FileName = fileName;
			mod.FolderName = folderName;
			mod.ModifiedTime = modifiedTime;
			mod.UserName = userName;
			mod.Comment = comment;
			mod.ChangeNumber = changeNumber;
			mod.EmailAddress = emailAddress;
			mod.Url = url;
			
			return mod;
		}

		public static Modification CreateModification(
			string fileName,
			string folderName)
		{
			return CreateModification(fileName,
				folderName,
				DateTime.Now,
				"SomeUser",
				"Comment",
				15,
				"someuser@somecompany.com",
				"http://someserver/someview");
		}
	}
}