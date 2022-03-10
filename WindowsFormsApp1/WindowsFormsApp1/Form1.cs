using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Теперь можно использовать следующий код для добавления элементов в БД (пример с таблицей customers):
            //using (UP1TaskEntities db = new UP1TaskEntities())
            //{
            //    Customer c = new Customer();
            //    c.Age = 20;
            //    c.Email = "example#mail.ru";
            //    c.FirstName = "John";
            //    c.LastName = "Johnson";
            //    c.PassportID = 111111;
            //    c.Phone = "7-921-123-45-67";
            //    db.Customers.Add(c);
            //    db.SaveChanges();
            //}


            ////Теперь можно использовать следующий код для добавления элементов в БД (пример с таблицей customers):
            //using (Database1Entities db = new Database1Entities())
            //{
            //    Customers c = new Customers();
            //    c.Age = 70;
            //    c.Email = "someeyail#mail.ru";
            //    c.FirstName = "Mike";
            //    c.LastName = "Pen";
            //    c.PassportId = 129856;
            //    c.Phone = "7-875-999-99-99";
            //    db.Customers.Add(c);
            //    db.SaveChanges();
            //}




            ////Изменение записи (пример с таблицей customers):
            //using (UP1TaskEntities db = new UP1TaskEntities())
            //{
            //    // получаем первый объект с именем Peter
            //    Customer p1 = db.Customers.Where((customer) => customer.FirstName == "John"
            //    ).FirstOrDefault();

            //    p1.Age = 30; // изменяем
            //    db.SaveChanges(); //сохраняем изменения
            //}







            ////Удаление записи (пример с таблицей customers):
            //using (UP1TaskEntities db = new UP1TaskEntities())
            //{

            //    Customer p1 = db.Customers.Where((customer) => customer.FirstName == "John").FirstOrDefault();
            //    if (p1 != null)
            //    {
            //        db.Customers.Remove(p1);
            //        db.SaveChanges();
            //    }
            //}



            ////Добавление в таблицу Booking (Пример с DateTime и TimeSpan):
            //using (UP1TaskEntities db = new UP1TaskEntities())
            //{
            //    Booking c = new Booking();
            //    c.ArrivalDate = new DateTime(2001, 01, 20);
            //    c.ArrivalTime = new TimeSpan(12, 30, 0);
            //    c.DepartureDate = new DateTime(2001, 01, 20);
            //    c.DepartureTime = new TimeSpan(12, 30, 0);
            //    c.CustomerId = db.Customers.Where(customer => customer.FirstName == "John").FirstOrDefault().Id;
            //    //c.RoomId = db.Rooms.FirstOrDefault().Id;
            //    db.Bookings.Add(c);
            //    db.SaveChanges();
            //}




            ////Вывод данных из соединения 2-х таблиц (Booking и Customers):
            //using (UP1TaskEntities db = new UP1TaskEntities())
            //{
            //    var bookings = db.Bookings.Join(db.Customers, //2-ая таблица (Customers)
            //        booking => booking.CustomerId, // FK из таблицы Bookings
            //        customer => customer.Id, // РК из таблицы Customers
            //        (booking, customer) => new // Формируем результат
            //        {
            //            FirstName = customer.FirstName,
            //            LastName = customer.LastName,
            //            Phone = customer.Phone,
            //            ArrivalDate = booking.ArrivalDate,
            //            DepartureDate = booking.DepartureDate,
            //        });
            //    foreach (var b in bookings)
            //        tbOutput.Text += string.Format("({0} {1}) Phone: {2} ArrivalDate: {3} DepartureDate: {4}\n",
            //            b.FirstName, b.LastName, b.Phone,
            //            b.ArrivalDate, b.DepartureDate);
            //}





            ////Получение данных из 3-х таблиц:

            //using (Database1Entities db = new Database1Entities())
            //{
            //    var bookings = from booking in db.Booking
            //                   join customer in db.Customers on booking.CustomerId equals customer.Id
            //                   join room in db.Rooms on booking.RoomId equals room.Id
            //                   select new
            //                   {
            //                       Name = customer.FirstName,
            //                       Price = room.Price,
            //                       ArrivalDate = booking.ArrivalDate,
            //                       DepartureDate = booking.DepartureDate
            //                   };
            //    foreach (var b in bookings)
            //        tbOutput.Text += string.Concat("Name: ", b.Name,
            //            " \nPrice: ", b.Price,
            //            " \nArrivalDate: ", b.ArrivalDate,
            //            " \nDepartureDate: ", b.DepartureDate,
            //            "\n----------\n");
            //}
        }
    }
}
