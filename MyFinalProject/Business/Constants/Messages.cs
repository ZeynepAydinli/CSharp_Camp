using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants;

public static class Messages
{
    public static string ProductAdded = "Ürün eklendi";
    public static string ProductNameInvalid = "Ürün ismi geçersiz";
    public static string MaintenanceTime = "Sistem bakımda";
    public static string ProductsListed = "Ürünler listelendi";
    public static string ProductCountOfCategoryError = "Kategoriye daha fazla ürün eklenemez";
    public static string ProductNameAlreadyExists = "Bu isimden başka bir ürün vardır";
    public static string ProductUpdated = "Ürün güncellendi";
    public static string CategoryLimitExceded = "Kategori sayısı limite ulaştığı için yeni ürün eklenemiyor";
}
