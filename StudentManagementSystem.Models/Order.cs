using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagementSystem.Models; 

public class Order
{
    public int Id { get; set; }
    public int CustoerId { get; set; }
    public string Orderdiscription { get; set; }
    public Customer Customer { get; set; }

    public List<OrderItem> Items { get; set; }
    
}

public class OrderItem
{
    public int Id { get; set; }
    public string Name { get ; set ;}

    public int  orderId { get; set; }

   public Order Order { get; set; }


}