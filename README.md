# WebApiRouting

<h3>Bu proje ASP.NET ile Web API projelerinde yönlendirme konusunun kavranması amacıyla yapılmıştır.</h3>

## Özet

Bu projede **yönlendirme** konusu kavranabilmesi için, ürün ve ders modellerinden oluşturulan 2 farklı Web API projesi yapılmıştır. Web API 'de 2 çeşit yönlendirme yapılandırması vardır. 

####Bunlar kullanılma sırasıyla:
	- Convention Based Routing
	- Attribute Based Routing

## Eklenen veya Güncellenen Dosyalar

- App_Start
	1. WebApiConfig.cs
- Controller 
	1. ProductApiController.cs
	2. ProductController.cs
	3. TeacherApiController.cs
	4. TeacherController.cs
- Filters
	1. LogAttribute.cs
- Models
	1. Lesson.cs
	2. Product.cs
- Views
	1. Product
		- Index.cshtml
	2. Teacher
		- Lessons.cshtml

## Yönlendirmelerin Test Edilmesi

#### Convention Based Routing

ASP.NET MVC projelerinde **RouteConfig** sınıfının **RegisterRoutes** metodundaki route tanımlamalarına benzer. Web API'lerde ise aynı yönlendirme **WebApiConfig** sınıfının **Register** sınıfından yapılır. Bu yönlendirme örneği için proje içerisinde **Product Modeli** ve **ProductApi ile Product Controller**'ları oluşturulmuştur.

İlk olarak ürünlerin listeleneceği sayfa açılır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/ConventionBasedRouting1.png)

Daha sonra **Ürünleri Listele** butonuna basılarak, ürünlerin listelenmesi sağlanır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/ConventionBasedRouting2.png)

> **Web API route** yapılandırması Convention Based Routing ile, **ASP.NET MVC route** yapılandırmasında kullanılan yöntemle benzer şekilde yapılabilir.

#### Attribute Based Routing

**Attribute Based Routing** yapılandırılması, **Web API 2** ile gelen bir özelliktir. Bu özellik ile büyük projelerdeki karmaşık route yapılandırmaları kolaylıkla gerçekleştirilebilir. Bu özelliği kullanırken genel bir route yapılandırması yapmak yerine, istenilen **action yada controller** sınıfına özel ** route attribute**'u tanımlanarak bir yönlendirme yapılır. Böylece karışıklık önlenmiş olur. Bu yönlendirme örneği için proje içerisinde **Lesson Modeli** ve **TeacherApi ile Teacher Controller**'ları oluşturulmuştur.

İlk olarak derlerin listeleneceği sayfa açılır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/AttributeBasedRouting1.png)

Daha sonra öğretmen adı seçilerek **Dersleri Listele** butonuna basılarak, öğretmene ait derlerin listelenmesi sağlanır.

![alt tag](https://github.com/bsokat/WebApiRouting/blob/master/Source/AttributeBasedRouting2.png)