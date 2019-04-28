using DevExpress.Xpf.Carousel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace NewEra.DepoSimulasyon
{
   public class MyCarousel : ObservableCollection<DepoModel>
    {
        public List<DepoModel> DepoList { get; set; }
        public CarouselItemsControl CIC { get; set; }
      
        public MyCarousel()
        { }

        public MyCarousel(List<DepoModel> depo,CarouselItemsControl cic)
        {
            try
            {
              
                
                for (int i = 0; i < depo.Count; i++)
                {
                    Add(new DepoModel(depo[i].Img, depo[i].Name, depo[i].Id));

                }
                DepoList = depo;
              
                CIC = cic;
                CIC.Carousel = new CarouselPanel(); 
                CIC.ItemsSource = DepoList;
                InitCarousel();
            }
            catch (Exception ex)
            {

                throw new Exception("\nMyCarousel\n"+ex.Message);
            }
            
        }

        private void InitCarousel()
        {
            try
            {
                SetAttractorPointIndex(out int vic, out int point, DepoList.Count);
                CIC.Carousel.VisibleItemCount = vic;
                CIC.Carousel.AttractorPointIndex = point;
                CIC.Carousel.ActivateItemOnClick = true;
             
               
                
            }
            catch (Exception ex)
            {

                throw new Exception("\nInitCarousel\n"+ex.Message);
            }
            
            
            
        }

        private void SetAttractorPointIndex(out int itemCount,out int point, int depoCount)
        {
            if (depoCount<4)
            {
                point = 1;
                itemCount = 3;
            }
            else
            {
                if(depoCount%2==0)
                {
                    depoCount++;
                    point = depoCount / 2;
                    itemCount = depoCount;
                }
                else
                {
                    point = depoCount / 2;
                    itemCount = depoCount;
                }
            }
        }
    }
}
