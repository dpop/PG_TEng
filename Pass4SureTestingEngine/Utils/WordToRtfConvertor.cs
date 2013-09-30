using System;

namespace Pass4SureTestingEngine.Utils
{
    class WordToRtfConvertor
    {
        public static bool ConvertToRtf(string wordPath, string rtfPath)
        {
            var newApp = new Microsoft.Office.Interop.Word.Application();


            object source = wordPath;
            object target = rtfPath;


            var unknown = Type.Missing;


            newApp.Documents.Open(ref source, ref unknown,
                 ref unknown, ref unknown, ref unknown,
                 ref unknown, ref unknown, ref unknown,
                 ref unknown, ref unknown, ref unknown,
                 ref unknown, ref unknown, ref unknown, ref unknown);

            object format = Microsoft.Office.Interop.Word.WdSaveFormat.wdFormatRTF;


            try
            {
                newApp.ActiveDocument.SaveAs(ref target, ref format,
                                             ref unknown, ref unknown, ref unknown,
                                             ref unknown, ref unknown, ref unknown,
                                             ref unknown, ref unknown, ref unknown,
                                             ref unknown, ref unknown, ref unknown,
                                             ref unknown, ref unknown);
            }
            catch (Exception)
            {
                
            }

            // for closing the application
            newApp.ActiveDocument.Close();  
            
            newApp.Quit(ref unknown, ref unknown, ref unknown);
            return true;
        }
    }
}
