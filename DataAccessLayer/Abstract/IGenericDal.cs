using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Abstract
{
    public interface IGenericDal<T> where T : class, new()
    {
        /*
         * Bu kod, Generic bir veri erişim katmanı (DAL - Data Access Layer) arayüzü tanımlayan bir C# kodudur. 
         * T bir tür parametresidir ve class anahtar kelimesi ile sınıf türü olduğunu belirtir. new() ise, 
         * T tipindeki nesnelerin varsayılan bir yapılandırıcıya sahip olması gerektiğini belirtir.
         * Yani, IGenericDal arayüzü, T tipiyle çalışan bir veri erişim katmanı sağlar ve 
         * T sınıf tipi olmalı ve parametresiz bir yapıcıya sahip olmalıdır. 
         * Bu, T tipiyle çalışırken, sınıf nesnesi oluşturmak için new() anahtar kelimesini kullanabilirsiniz.
         */

        void Insert(T t);
        void Delete(T t);
        void Update(T t);
        T GetById(int id);
        List<T> GetListAll();
    }
}
