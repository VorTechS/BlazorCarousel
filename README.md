# BlazorCarousel
A basic Blazor Carousel component, that right now only supports images.  I suspect it could very easily be extended to support any content.

###### Basic usage

Add a reference to your project, referencing the 'Components' project

In your _Host.cshtml file add the following line to use the default stylesheet:

    <link href="_content/Components/blazorcarousel.css" rel="stylesheet" />

Add the component to your Razor page using the following lines:

        @using Components;

        <Carousel imageset="@AssetImages" CssClass="col-12" AutoScrollInterval="5"></Carousel>

... where @AssetImages is a reference to a List<ImageFile> that you build up yourself.

The ImageFile can either have FileContent (the image bytes) or a Url specified.
The sample project contains examples of both in the CarouselSample.razor page

###### Current Carousel Parameters:

imageset: a List<FileImage> for the carousel to render
    
CssClass: additional CSS classes that you want to apply to the carousel outer container

ImageClass: additional CSS classes that you want to apply to the indivudal IMAGE containers (Note: applied to all)

OnCarouselItemClicked: event handler for when an item is clicked (also changes the cursor to reflect an image can be clicked)

AutoScrollInterval: the number of seconds to elapse before the next image in the sequence is displayed automatically

ShowNavigation: (Defaulted to true) allows the bottom navigation panel to be displayed or hidden
