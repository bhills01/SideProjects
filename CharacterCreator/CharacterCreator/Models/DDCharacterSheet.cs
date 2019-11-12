using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CharacterCreator.Models
{
    public class DDCharacterSheet
    {
        public DDCharacter Character { get; set; }

        public void FillForm(DDCharacter character)
        {
            using (FileStream outFile = new FileStream(@"C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\wwwroot\Forms\Charesult.pdf", FileMode.Create))
            {
                PdfReader pdfReader = new PdfReader(@"C:\Users\BHills\GIT\hills-side-projects\CharacterCreator\CharacterCreator\wwwroot\Forms\5E_CharacterSheet_Fillable - Copy.pdf");
                PdfStamper pdfStamper = new PdfStamper(pdfReader, outFile);
                AcroFields fields = pdfStamper.AcroFields;


                fields.SetField("PlayerName", character.PlayerName.ToString());
                fields.SetField("Race ", character.Race.ToString());
                fields.SetField("Alignment", character.Alignment);
                fields.SetField("CharacterName", character.CharacterName);
                

                // flatten the form to remove editting options, set it to false  
                // to leave the form open to subsequent manual edits  
                pdfStamper.FormFlattening = false;
                // close the pdf  
                pdfStamper.Close();
            }
        }
    }
}
