using System;
using System.IO;
using System.Runtime.InteropServices;

namespace Delete_Cusom_File
{
    class Program
    {
        static void Main(string[] args)

        {
            // files inside reseffect
            string[] reseffectFiles = { "Dmg_GTI_Bomb.nif", "BurnPain.nif", "BurnPainDmg.nif", "StaBurnPainLoop.nif", "StaBurnPainMe_Last.nif", "StaBurnPainMeLoop.nif", "StaMobACS01.nif", "StaMobACS01Loop.nif", "StaMobMRS01.nif", "StaMobMRS01Loop.nif", "StaMobMSD02Loop.nif", "StaNortfBurn.nif", "WeddingMark01.nif", "StaBlueDragon.nif", "StaRedDragon.nif", "RedDragonProtection.nif", "Sta_BlueDragon.nif", "Sta_RedDragon.nif", "WeddingMark01.nif", "Aura100.nif", "Aura120.nif", "ItemEffect007.nif", "ItemEffect027.nif", "ItemEffect047.nif", "ItemEffect065.nif", "ItemEffect077.nif", "ItemEffect087.nif", "ItemEffect097.nif", "StaBurnPainMeLoop.nif", "StaBurnPainMe_Last.nif", "BurnPainDmg.nif", "BurnPainMe.nif", "KazhulEffect01.nif", "KazhulEffect02.nif" };

            var itemEffectInsdeReseffectFolder = @"*ItemEffect*.nif";
            var reseffectFolder = Environment.CurrentDirectory + @"\reseffect";
            var resitemFolder = Environment.CurrentDirectory + @"\resitem";
            var femaleFolderInsideResitem = Environment.CurrentDirectory + @"\resitem\Female";
            var maleFolderInsideResitem = Environment.CurrentDirectory + @"\resitem\Male";
            var commonFolderInsideReschar = Environment.CurrentDirectory + @"\reschar\Common";
            var currentFolder = Environment.CurrentDirectory;

            try
            {
                // delete files inside reseffect folder
                for (int i = 0; i < reseffectFiles.Length; i++)
                {
                    string[] filesInReseffectFolder = Directory.GetFiles(reseffectFolder, reseffectFiles[i]);
                    foreach (string file in filesInReseffectFolder)
                    {
                        File.Delete(file);
                        Console.WriteLine(file + " has been deleted!");
                    }
                }

                // delete itemeeffect.nif files inside resefffect
                foreach (string file in Directory.GetFiles(reseffectFolder, itemEffectInsdeReseffectFolder))
                {
                    File.Delete(file);
                    Console.WriteLine(file + " has been deleted!");
                }

                // delete resitem/male, resitem/female, reschar/common folder
                while (Directory.Exists(commonFolderInsideReschar) || Directory.Exists(maleFolderInsideResitem) || Directory.Exists(femaleFolderInsideResitem))
                {
                    Directory.Delete(femaleFolderInsideResitem, true);
                    Directory.Delete(maleFolderInsideResitem, true);
                    Directory.Delete(commonFolderInsideReschar, true);
                    Console.WriteLine(femaleFolderInsideResitem + " folder has been deleted!");
                    Console.WriteLine(maleFolderInsideResitem + " folder has been deleted!");
                    Console.WriteLine(commonFolderInsideReschar + " folder has been deleted!");
                }

                // delete files insde resitem folder
                foreach (string file in Directory.GetFiles(resitemFolder))
                {
                    File.Delete(file);
                    Console.WriteLine(file + " has been deleted!");
                }
            } 
            catch
            {
                Console.WriteLine("You are in " + currentFolder + " Folder!");
                Console.WriteLine("Place the sk.exe program inside FiestaOnline main folder!");
            }
            
            Console.ReadKey();
        }
    }
}
