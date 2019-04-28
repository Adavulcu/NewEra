using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using NewEraDepoTemplateCreater.Models;
namespace NewEraDepoTemplateCreater
{
    public class RafModel :BaseAdresModel
    {
        public RafModel(string name,string alias, int count, ColorModel color, List<LabelModel> coordinats, Guid rafId, Guid katID, Guid depoId, bool isBound) :base(rafId,katID,name)
        {
            Name = name;
            Color = color;
            Coordinats = coordinats;
            Id = rafId;
            UlId = katID;
            DepoId = depoId;
            Alias = alias;
            SiraAdedi = count;
            IsBound = isBound;
        }


        public RafModel(string name, string alias, ColorModel color, List<LabelModel> coordinats, Guid rafId, Guid katID, Guid depoId, bool isBound) : base(rafId, katID, name)
        {
            Name = name;
            Color = color;
            Coordinats = coordinats;
            Id = rafId;
            UlId = katID;
            DepoId = depoId;
            Alias = alias;
            IsBound = isBound;
        }

        public RafModel(string name,string alias, int count, ColorModel color, List<LabelModel> coordinats)
        {
            Name = name;
            Alias = alias;
            Color = color;
            Coordinats = coordinats;
            SiraAdedi = count;
        }

        public RafModel(string name, int count ,List<RafSiraModel> rafSira,Guid id, Guid ulId,Guid depoId,bool isBound):base(id,ulId,name)
        {
            Name = name;
            Id = id;
            UlId = ulId;
            DepoId = depoId;
            RafSira = rafSira;
            SiraAdedi = count;
            IsBound = isBound;
        }

        public RafModel() { }

        public string Alias { get; set; }
        public ColorModel Color { get; set; }
        public List<RafSiraModel> RafSira { get; set; }
        public List<LabelModel> Coordinats { get; set; }
        public int SiraAdedi { get; set; }
        public Guid DepoId { get; set; }
        public bool IsBound { get; set; }
       

    }
}
