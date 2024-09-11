var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();


var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "Default",
    pattern: "{controller=Home}/{action=Index}");

app.Run();


// Controller: Kullanıcı isteklerini alır, bir View'ı geri döndürür.
//Action: HTTP isteği geldiğinde bu metot çağrılır. Sonuç olarak bir View veya başka bir yanıt döndürmek için kullanılır.
//Model: Uygulamanın iş verilerini temsil eder ve genellikle veritabanı ile etkileşimde bulunur.
//Veriyi saklamak veya doğrulamak için kullanılabilir.Genellikle class olarak eklenir.
//View: View, Controller'dan aldığı veriyi kullanıcıya uygun html formatında sunar.
//Razor: C# kodunu HTML içinde kullanmamıza yarar. "@" ile gösterilir ve dinamik verilerle çalışabilmemizi sağlar.
//RazorView: Razor kullanılarak oluşturulan bir View'dır.
//wwwroot: ASP.NET Core uygulamalarında statik dosyaların (CSS, JavaScript, resimler vs.) saklandığı klasördür.
//app.Run(): Uygulamanın isteklere nasıl yanıt vereceğini belirler ve genellikle uygulama çalışırken bir son işlev olarak çağrılır.
//app.Run() metodu, isteklere yanıt vermek için gerekli olan kodu içerir ve genellikle uygulamanın ana iş mantığını tanımlar.
//builder.Build(): ASP.NET Core uygulamasının yapılandırma sürecinin son adımıdır. Bu metod, uygulamanın yapılandırma ayarlarını, servisleri ve middleware'leri içeren bir IHost örneği oluşturur.
//Uygulamanın çalışma zamanı için gerekli olan tüm bileşenleri bir araya getirir ve yapılandırılmış uygulama nesnesini döndürür. Bu aşamadan sonra uygulama çalışmaya hazırdır.