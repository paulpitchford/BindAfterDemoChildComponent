# Bind After Demo
This is a demo of the use of the .net7 feature for binding: bind-Value:after. If you use an EventCallback parameter in the child component as at VS 17.4.4 you will receive an error from the compiler stating: 

> Can't convert from EventCallback<T> to Func<T,Task>

The bug was originally reported at: [https://github.com/dotnet/aspnetcore/issues/44957](https://github.com/dotnet/aspnetcore/issues/44957)

Other work arounds can be found here: [https://github.com/javiercn/BindGetSetAfter701/blob/main/BindGetSetAfter701/Client/Pages/Index.razor?rgh-link-date=2022-12-14T11%3A45%3A43Z](https://github.com/javiercn/BindGetSetAfter701/blob/main/BindGetSetAfter701/Client/Pages/Index.razor?rgh-link-date=2022-12-14T11%3A45%3A43Z)
