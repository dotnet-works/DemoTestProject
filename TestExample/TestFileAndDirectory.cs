using Allure.NUnit;
using Allure.NUnit.Attributes;
using FluentAssertions;


namespace TestExample
{

    [AllureNUnit]
    [TestFixture]
    public class TestFileAndDirectory
    {

        string _TestDataPath = Directory.GetCurrentDirectory().Split("bin")[0]+"TestData/";
        string? _TestDir;


        [OneTimeSetUp]
        [AllureBefore("Start the test server")]
        public void OneTimeInitTest()
        {
            _TestDir= $"{_TestDataPath}Test123";
            //_TestDir = Path.Combine(_ProjectPath, "TestData"+TestTempDirectory);
            //_TestDir = Path.Combine(_ProjectPath, "Test123");

            if(Directory.Exists(_TestDir)) {
               Directory.Delete(_TestDir,true);
            }

        }





        [Test]
        [Description("Create New Directory If Not Exist")]
        [AllureStep("Create New Directory Existince")]
        public void CheckDirectoryExistTest1()
        {

            //AllureLifecycle.Instance.UpdateStep(stepResult =>);
            


            Console.WriteLine($"Project Path: {_TestDataPath} TestDir Path: {_TestDir}");
            bool checkDir = Directory.Exists(_TestDir);
            //if (checkDir.Should().BeFalse().Equals(false))
            if (!Directory.Exists(_TestDir))
            {
                //Directory.CreateDirectory(_TestDir);
                Directory.CreateDirectory(_TestDir);
                Console.WriteLine("DirectoryCreated");
                
            }


            string path1 = @"E:\AppServ\Example.txt";
            //string path = _TestDir + "/TestFile.txt";

            //Console.WriteLine($"File Path: {path}");
            for(int i = 0; i < 3; i++)
            {
                string path = _TestDir + $"/TestFile{i}.txt";
                Console.WriteLine($"File Path: {path}");

                if (!File.Exists(path))
                {
                    //File.Create(path).Dispose();
                    using (TextWriter tw = new StreamWriter(path, true))
                    {
                        tw.WriteLine("The very first line!");
                        tw.Close();
                    }
                }
            }

            //if (!File.Exists(path))
            //{
            //    //File.Create(path).Dispose();

            //    using (TextWriter tw = new StreamWriter(path, true))
            //    {
            //        tw.WriteLine("The very first line!");
            //        tw.Close();
            //    }

            //}
            //else if (File.Exists(path))
            //{
            //    using (TextWriter tw = new StreamWriter(path, true))
            //    {
            //        tw.WriteLine("The next line!");
            //        tw.Close();
            //    }
            //}



        }

        [Test]
        [Description("Create Files Under Directory")]
        public void CreateFilesUnderDirectoryTest2()
        {

        }

        [Test]
        [Description("Delete All Files Under Directory")]
        public void DeleteAllFilesUnderDirectoryTest3()
        {

        }



        [Test]
        [Description("")]
        public void CopyAllDirectoriesToAnotherTest4()
        {
            string srcDirPath = _TestDir;
            string targetDirPath = _TestDataPath + "/allure-history";

            CopyContent(srcDirPath, targetDirPath);
        }

        [Test]
        [Description("Delete Directory")]
        public void DeleteDirectoryTest4()
        {
            //bool _delDir;
            //if (Directory.Exists(_TestDir))
            //{
            //    Directory.Delete(_TestDir, true);
            //    Console.WriteLine("Directory Deleted");
            //}
        }

        public static void CopyContent(string srcDirPath,string targetDirPath)
        {
            Console.WriteLine($"Src: {srcDirPath}  Target:{targetDirPath}");
            if(!Directory.Exists(srcDirPath)) {  throw new Exception("No Directory path found"); }

            if (!Directory.Exists(targetDirPath)) { Directory.CreateDirectory(targetDirPath); }
            

            foreach (var srcPath in Directory.GetFiles(srcDirPath))
            {
                //Copy the file from sourcepath and place into mentioned target path, 
                //Overwrite the file if same file is exist in target path
                File.Copy(srcPath, srcPath.Replace(srcDirPath, targetDirPath), true);
            }
        }

        





}
}
