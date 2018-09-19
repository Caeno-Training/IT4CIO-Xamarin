# Treinamento de Xamarin IT4CIO
Repositório dos arquivos referentes ao treinamento de Xamarin para equipe da IT4CIO.

# Slides das Aulas
Os slides das aulas ministradas estão disponíveis como PDF:
* [Apresentando a plataforma Xamarin](slides/Aula01–Apresentando_a_plataforma_Xamarin.pdf)
* [Introdução a Plataforma iOS](slides/Aula02-Introducao_a_Plataforma_iOS.pdf)
* [Introdução a Plataforma Android](slides/Aula03_Introducao_a_plataforma_Android.pdf)
* [Introdução ao Xamarin.Forms](slides/Aula04-XamarinForms.pdf)

# Projetos
Os projetos desenvolvidos durante as aulas estão disponíveis para pesquisa na pasta [src](src).

# Referências
Referências e materiais complementares aos conteúdos ministrados em aula.

## Xamarin.Forms
* [Repositório do Xamarin.Forms no GitHub](https://github.com/xamarin/Xamarin.Forms)
* [Data Binding](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/data-binding/): documentação oficial do recurso de Data Binding.
* [CSS - Xamarin University](https://www.youtube.com/watch?v=va-Vb7vtan8): Aula do Xamarin University explicando a aplicação de estilos com CSS, recurso incorporado ao Xamarin.Forms a partir da versão 3.0.

### Componentes da plataforma:
* [Páginas](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/pages): documentação oficial dos componentes `Pages` disponíveis por padrão no Xamarin.Forms.
* [Layouts](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/layouts): documentação oficial dos diversos tipos de Layouts disponíveis no Xamarin.Forms para organização dos componentes visuais.
    * FlexLayout:
        * [Documentação Oficial](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/layouts/flex-layout#related-links): documentação oficial completa do FlexLayout, incluindo descrições de todas a propriedades mais importantes.
        * [FlexLayout - Xamarin University](https://www.youtube.com/watch?v=Ng3sel_5D_0): Aula do Xamarin University explicando o uso do componente `FlexLayout`, incorporado ao Xamarin.Forms a partir da versão 3.0.
        * [FlexLayoutDemos](https://developer.xamarin.com/samples/xamarin-forms/UserInterface/FlexLayoutDemos/): Códigos de exemplos de aplicação do FlexLayout em diversos tipos de cenários.
* [Views](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/views): documentação oficial dos diversos Views e Controles disponíveis no Xamarin.Forms.
* [Cells](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/user-interface/controls/cells): documentação oficial dos tipos de células padronizadas que podem ser usadas na construção de `ListViews` e `TableViews`.

### Tópicos Complemenatres
Tópicos adicionais aos apresentados durante o curso, muito úteis no desenvolvimento de projetos Mobile com Xamarin.Forms, os quais recomendamos um estudo aprofundado.

* [Custom Renderers](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/custom-renderer/): possibilita criar novos componentes visuais baseados em implementações nativas, ou personalizar componentes existentes do Xamarin.Forms.
* [Platform Effects](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/app-fundamentals/effects/): possibilita personalizar componentes existentes do xamarin.forms manipulando sua renderização nativa.
* [Native Embbeding](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/native-views/): possibilita incluir controles nativos das plataformas iOS ou Android diretamente em páginas XAML.
* [Native Forms](https://docs.microsoft.com/en-us/xamarin/xamarin-forms/platform/native-forms): possibilita integrar páginas específicas do Xamarin.Forms em projetos nativos de Android ou iOS.

### Componentes Fundamentais
Lista de componentes fundamentais que facilitam necessidades comuns da maioria dos projetos Mobile.

* [Xamarin.Essentials](https://docs.microsoft.com/en-us/xamarin/essentials/?context=xamarin/xamarin-forms): Biblioteca com acesso a diversos recursos nativos dos dispositivos através de uma interface unificada. Destaque para acesso a Geolocalização.
* [Xamarin.Forms.GoogleMaps](https://github.com/amay077/Xamarin.Forms.GoogleMaps): Fork do projeto Forms.Maps original, usando o Google Maps no iOS em lugar dos mapas nativos da Apple.
* [SkiaSharp](https://docs.microsoft.com/en-us/xamarin/graphics-games/skiasharp/introduction): implementação .NET da biblioteca Skia para desenha e manipulação de gráficos 2D com alta performance. Compatível com Forms.
* [ACR.UserDialogs](https://github.com/aritchie/userdialogs): biblioteca Cross-Platform que possibilita chamar caixas de diálogo nativas de cada plataforma. Indispensável para trabalho com Forms.
* [PropertyChanged.Fody](https://github.com/Fody/PropertyChanged): um plugin da biblioteca Fody que implementa automaticamente a interface INotifyPropertyChanged, necessária para o DataBinding, durante o processo de compilação.
* [EntityFramework.Core](https://docs.microsoft.com/en-us/ef/core/): versão portável da biblioteca Entity Framework da Microsoft, poderosa ferramenta de ORM para plataforma .NET. Permite a criação de modelos com persistência em SQLite.
    * [Videoaula na Xamarin.University](https://www.youtube.com/watch?v=cZ1PmKeIzL4)
* [Flurl.Http](https://flurl.io): biblioteca extremamente versátil para composição de requests HTTP. Permite a criação de um modelo de comunicação com API’s através de um código unificado.
* [Polly](www.thepollyproject.org): uma biblioteca para facilitar o tratamento de código que pode potencialmente falhar, como chamadas de rede ou gravação em disco. Funciona através de Policies, onde é possível facilmente determinar tentativas sucessivas ou Timeout.