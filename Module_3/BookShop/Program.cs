// See https://aka.ms/new-console-template for more information
using BookShop;

var bought = new[] { 1,1,2,2,3,3,4,5};

var books = new Order();

var order = books.calculatePrice(bought);
Console.WriteLine(order);

