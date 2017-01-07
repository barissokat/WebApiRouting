# FilterTypes

<h3>Bu proje ASP.NET ile Web API projelerinde yönlendirme konusunun kavranması amacıyla yapılmıştır.</h3>

## Özet

Bu projede **yönlendirme** konusu kavranabilmesi için, ürün ve öğretmen modellerinden oluşturulan 2 farklı Web API projesi yapılmıştır. Web API 'de 2 çeşit yönlendirme yapılandırması vardır. 

####Bunlar kullanılma sırasıyla:
	- Convention Based Routing
	- Attribute Based Routing

## Yönlendirmelerin Test Edilmesi

#### Convention Based Routing

ASP.NET MVC projelerinde **RouteConfig** sınıfının **RegisterRoutes** metodundaki route tanımlamalarına benzer. Web API'lerde ise aynı yönlendirme **WebApiConfig** sınıfının **Register** sınıfından yapılır. Bu yönlendirme örneği için proje içerisinde **Product Modeli** ve **ProductApi ile Product Controller**'ları oluşturulmuştur.

Ürünlerin listeleneceği sayfa açılır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/ConventionBasedRouting1.png)

Daha sonra **Ürünleri Listele** butonuna basılarak, ürünlerin listelenmesi sağlanır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/ConventionBasedRouting2.png)