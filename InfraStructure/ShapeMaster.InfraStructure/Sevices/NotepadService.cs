using ShapeMaster.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeMaster.InfraStructure.Sevices
{
    public class NotepadService
    {
        public void SaveToNotePad(ISaveable saveable) 
        {
            File.AppendAllText("C:\\Users\\USER\\source\\repos\\ShapeMaster\\Database\\Save.txt", saveable.GetInfo());
        } 
    }
}
