
Author: Utkarsh Himanshu Patel
Date: 2021-07-24
Filename: README.md

<<<<<<<<CREATING PERSONAL WEB APPLICATION>>>>>>>>

0800 - creating a default web app using the command called "dotnet new webapp -o W0785541".
0801 - successful created a web app using the above command.
0815 - passed the command called "dotnet dev-certs https --trust" to make the site trustable and allows a certificate by own.
0816 - the above command runs successful and it's granted the certificate to the site.
0830 - now, tried to run the default created web apps with the command called "dotnet run".
0831 - successfully runs the command and get the link of the web app.
0840 - after copy paste the link from the terminal and tried to run in the firefox browser.
0841 - successfully launched the web app on the browser.
0900 - tried to get familiar with the default site created.
0910 - tried to inspect the site and watch the "Home Page" and "Privacy page" code.
0915 -  tried to creating own page using the syntax of HTML-5.
0945 - successfully created a code that displays the body text, header and footer and Image as well.
1000 - created a new .CSS file under the folder css which is subfolder of wwwroot.
1011 - tried to apply the css on the home page but It doesn't applied to it.
1030 - tried to stop or comment out "<li class="nav-item"><a class="nav-link text-dark" asp-area="" asp-page="/Index">Home</a></li> " from the _layout.cshtml because of I want to run my personal .CSS file called "myStyle.css" and also put the command called @RenderSection("Styles", false) in side _Layout.cshtml file just after title tag to ensure thet it doesn't load the file "site.css".
1045 - linking my style sheet to the Index.cshtml file by using the code called "@section Styles{<link rel="stylesheet" href="~/css/myStyles.css" />}"
1050 - successfully show the css applied to the Index.cshtml file while refreshing the site.
1100 - there is a problem with the image because its not visible on site.
1130 - tried to created a folder for image called "IMG" inside the css folder which is the subfolder of the wwwroot.
1145 - tried to link the image with the Index.cshtml file with the <img> tag and inside the src i pasted the path of the image placed inside of IMG folder.
1200 - The image shown successfully.
1211 - created a new file called "Hobbies.cshtml" and "Hobbies.cshtml.cs" inside the folder called "Pages".
1215 - copied the code of the file "Index.cshtml" inside the "Hobbies.cshtml" file.
1230 - copied the code of the file "Index.cshtml.cs" inside the "Hobbies.cshtml.cs" file and tried to replace the code accordingly to set it in Hobbies.cshtml.cs file.
1245 - after write the code for the next page using the syntax of HTML-5 and add text inside it.
1250 - after that link the file called "myStyles2.css" inside the Hobbies.cs.html file for getting the personal css applied on the site.
0130 - after that run the file and make sure that css applied to it and successfully get my css applied to newly created page called "Hobbies.cshtml".
0145 - created a navigation link to move to the "Home" and "Hobbies" page just by clicking on it, on both the pages.
0148 - tried to created a code "return to top" that will move or scroll the user to top of the page by clicking on RETURN TO TOP button in Hobbies page.
0150 - tried to eliminate or pause the running the code privacy page by commenting it out.
0155 - tried to make sure that there is the only both page on the web app ie. "Home" and "Hobbies".
0200 - finally, verified that both pages worked fine and get my desired output.