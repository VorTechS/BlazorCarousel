# BlazorCarousel

A templated Blazor Carousel (TemplatedCarousel) component and the original Image Carousel (Carousel) it started life from.

The project started life as a basic Image Carousel and was extended to add some 'useful' features and finally I took the plunge to make it support templating, meaning any content can be embedded into the Carousel.

The sample project contains some embedded images and renders the images into both components showing the various options.

###### Basic usage

Add a reference to your project, referencing the 'Components' project

In your _Host.cshtml file add the following line to use the default stylesheet:

    <link href="_content/Components/blazorcarousel.css" rel="stylesheet" />

Add the component to your Razor page using the following lines:

        @using Components;

For the old carousel, add the following line to create an instance:

        <Carousel imageset="@AssetImages" CssClass="col-12" AutoScrollInterval="5"></Carousel>

... where @AssetImages is a reference to a List of ImageFile that you build up yourself.

The ImageFile can either have FileContent (the image bytes) or a Url specified.
The sample project contains examples of both in the CarouselSample.razor page

For the templated carousel, add lines similar to the following:

    <TemplatedCarousel Items="AssetImages" TItem="ImageFile">
        <ItemTemplate>
            <img class="center" src="@GetImageSource(@context)" alt="@context.FileName">
        </ItemTemplate>
    </TemplatedCarousel>


###### Current Carousel Parameters:

imageset: a List<FileImage> for the carousel to render
    
CssClass: additional CSS classes that you want to apply to the carousel outer container

ImageClass: additional CSS classes that you want to apply to the indivudal IMAGE containers (Note: applied to all)

OnCarouselItemClicked: event handler for when an item is clicked (also changes the cursor to reflect an image can be clicked)

AutoScrollInterval: the number of seconds to elapse before the next image in the sequence is displayed automatically

ShowNavigation: (Defaulted to true) allows the bottom navigation panel to be displayed or hidden

###### Current TemplatedCarousel Parameters:

TItem: The type of item being rendered

Items: The List of items to be rendered
   
ItemTemplate: The HTML templated being used to render the items
   
CssClass: additional CSS classes that you want to apply to the carousel outer container

OnCarouselItemClicked: event handler for when an item is clicked (also changes the cursor to reflect an image can be clicked)

AutoScrollInterval: the number of seconds to elapse before the next image in the sequence is displayed automatically

ShowNavigation: (Defaulted to true) allows the bottom navigation panel to be displayed or hidden
