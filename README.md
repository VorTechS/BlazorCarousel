# BlazorCarousel
A basic Blazor Carousel component, that right now only supports images.  I suspect it could very easily be extended to support any content.

Basic usage

Add a reference to your project, referencing the 'Components' project

In your _Host.cshtml file add the following line to use the default stylesheet:

    <link href="_content/Components/blazorcarousel.css" rel="stylesheet" />

Add the component to your Razor page using the following lines:

        @using Components;

        <Carousel imageset="@AssetImages" CssClass="col-12" AutoScrollInterval="5"></Carousel>

... where @AssetImages is a reference to a List<ImageFile> that you build up yourself.

The ImageFile can either have FileContent (the image bytes) or a Url specified.
The sample project contains examples of both in the CarouselSample.razor page