<html>
<head>
<title>yemekbizdensorulur.com</title>
<link rel="stylesheet" type="text/css" href="styles.css"></link>

<script type="text/javascript" src="http://code.jquery.com/jquery-1.4.2.min.js"></script>
<script type="text/javascript" src="JS/cufon-yui.js"></script>
<script type="text/javascript" src="fonts/aura_400.font.js"></script>
</head>

<script type="text/javascript">
  $(document).ready(function()
  {
   
	 var default_image = '';
	 var default_caption = '';
	 
	 loadPhoto(default_image, default_caption);
	 
	 
	 function loadPhoto($url, $caption)
	 {
	 
	    showPreloader();
	    var img = new Image();
	    jQuery(img).load( function() 
		{
			jQuery(img).hide();
			hidePreloader();
		
        }).attr({ "src": $url });
	
	    $('#largephoto').css('background-image','url("' + $url + '")');
		$('#largephoto').data('caption', $caption);
	 }

	 $('.thumb_container').click(function()
	 {
	     
		  var handler = $(this).find('.large_image');
		  var newsrc  = handler.attr('src');
		  var newcaption  = handler.attr('rel');
		  loadPhoto(newsrc, newcaption);
	 
	 });
	 

	 $('#largephoto').hover(function()
	 {
	    
		var currentCaption  = ($(this).data('caption'));
		var largeCaption = $(this).find('#largecaption');
		
		largeCaption.stop();
		largeCaption.css('opacity','0.9');
		largeCaption.find('.captionContent').html(currentCaption);
		largeCaption.fadeIn();		
		 largeCaption.find('.captionShine').stop();
         largeCaption.find('.captionShine').css("background-position","-550px 0"); 
         largeCaption.find('.captionShine').animate({backgroundPosition: '550px 0'},700);		 
		 Cufon.replace('.captionContent');
		

	 },
	 
	 function()
	 {
	    var largeCaption = $(this).find('#largecaption');
		largeCaption.find('.captionContent').html('');
		largeCaption.fadeOut();
	 
	 });
	
	
	 $('.thumb_container').hover(function()
	 {  
         $(this).find(".large_thumb").stop().animate({marginLeft:-7, marginTop:-7},200);
		 $(this).find(".large_thumb_shine").stop();
         $(this).find(".large_thumb_shine").css("background-position","-99px 0"); 
         $(this).find(".large_thumb_shine").animate({backgroundPosition: '99px 0'},700);
			 
	 }, function()
	 {
	    $(this).find(".large_thumb").stop().animate({marginLeft:0, marginTop:0},200);
	 });
	 
	 function showPreloader()
	 {
	   $('#loader').css('background-image','url("images/interface/loader.gif")');
	 }
	 
	 function hidePreloader()
	 {
	   $('#loader').css('background-image','url("")');
	 }
   
  });
</script>

<div id="container">
<div id="containertitle">

</div>
   <div class="mainframe">
      <div id="largephoto">
	  <div id="loader"></div>
	  
	  
	    <div id="">
		   
		</div>
		
       <div id="largetrans">  
      </div>
	        
      </div>
      
   </div>
   <div class="thumbnails">
   <br><br><br>

                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample1.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample1.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
   
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample2.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample2.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
 
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample3.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample3.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
     
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample4.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample4.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
   
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample5.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample5.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
    
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample6.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample6.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
    
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample7.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample7.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
       
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample8.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample8.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
      
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample9.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample9.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
     
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample10.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample10.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>

                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample11.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample11.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
       
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample12.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample12.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
       
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample13.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample13.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
       
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample15.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample15.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
      
                    <div class="thumbnailimage">
                        <div class="thumb_container"> 
                            <div class="large_thumb"> 
                        		<img src="images/thumbnails/sample14.jpg" class="large_thumb_image" alt="" /> 
                                <img src="images/large/sample14.jpg" class="large_image" rel="" />
                                <div class="large_thumb_border"></div>
                                <div class="large_thumb_shine"></div>
                              </div>
						</div>
                       </div>
    
   </div>
</div>


</html>
