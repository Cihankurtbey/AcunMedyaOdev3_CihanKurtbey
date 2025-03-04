/*  3-Abstract class soyut bir sınıftır soyut sınıftan nesne üretilmez ama içine soyut olmayan methodlar yazılabilir diğer sınıflara kalıtım verebilir.
    4-İnterfaceler ile abstrac classlar arasındaki en büyük fark interfaceler bir sınıfa birden fazla interface kalıtım verebilir ama abstrac classtan kalıtım alan bir sınıf yalnızca bir abstract classtan kalıtım alabilir.
      interfacelerde implementasyon yapılmaz.

*/
using AcunMedyaOdev3__3_4_5__CihanKurtbey;

Car myCar = new Car("Tesla"); // modele audi girerseniz mazotla dolduğunu söyleyecektir.
        
        myCar.Recharge();
        
       
        myCar.Refuel();