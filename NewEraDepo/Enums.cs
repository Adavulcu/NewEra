using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewEraDepo
{
    #region Durum Tanımlamaları
    public enum DurumIsEmri
    {
        Olusturma,
        Baslama,
        AraVerme,
        Devam,
        Bitis,
        BaskasinaAktarildi // İş başka personele bitirmesi için devredilebilir (?)
    }
    public enum DurumArac
    {
        Giris,
        YukIndirmeEmriOlusturuldu,
        YukIndirme,
        YukBindirmeEmriOlusturuldu,
        YukBindirme,
        Bekleme,
        Cikis
    }
    public enum DurumDepoIciArac
    {
        Aktif,
        Mesgul,
        Arizali
    }
    #endregion

    #region Tip Tanımalamaları

    public enum TipIsEmri
    {
        YukIndirme,
        Yukleme,
        Yerlestirme
    }

    public enum TipAdres
    {
        Hucre=0,
        ToplamaAlan=1,
        Kapi=2
    }

    #endregion

    #region Form Nesneleri
    public enum FormNesnesi
    {
        Label = 9999,
        TextEdit = 9998
    }
    #endregion

    #region DB Alan Tanımalamaları
    public enum Yetki
    {
        Giris,
        Guncelleme,
        Ekleme,
        Silme
    }
    #endregion
}
