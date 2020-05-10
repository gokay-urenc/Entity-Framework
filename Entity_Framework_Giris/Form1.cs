using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity_Framework_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NORTHWNDEntities db = new NORTHWNDEntities();
            dataGridView1.DataSource = db.Customers.ToList();
        }
    }
}
// Entity Framework: Database yansımasını projeye entegre eden bir Framework'tür.
// Entity Framework'un 3 yapısı vardır.
// * DatabaseFirst(DB First) yaklaşımı: Hazır bir db varsa ve bunu kullanacaksak o db'nin          yansımasını uygulamaya yansıtır. Yani veritabanındaki tabloları projeye class olarak aktarır.
// * Model First yaklaşımı: Proje tarafında database oluşturulur. Tablolar projede yapılır ve daha sonra bunun şeması db tarafına aktarılır.
// * Code First yaklaşımı: Herhangi bir db veya yansıması yoktur. Tamamen yansımayı kendimiz       yazarız. Örneğin employees tablosu olacak. Bunun için classı yazmak gerekir. Programı           çalıştırdığımızda database arkada kendisi yaratılır.
// Entity Framework bir ORM mimarisidir.
// Orm(Object Relation Mapping): Veritabanımızda yaratmış olduğumuz her bir nesneye karşılık kod   tarafında bir nesne oluşturan programlardır. Bu programlar code generation tekniği kullanarak   bizim yazmamız gereken kodu otomatik olarak üretir. OOP mantığına uygun bir şekilde bizim       veritabanımızda bulunan tabloları birer nesne örneklerini oluşturur.