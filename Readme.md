Learning Basic C# with .Net Maui using MVVM and SQLite CRUD ( Create , Read , Update , Delete)

About APP 

This should make windows and android version of app to add , read update and delete coffee database using MVVM toolkit and SQLite.
This is very basic app that i try to create base on what i learn from youtube and other website. I am appreacite if all expert come in help optimize and answer question if any a raise ..

Requirement :

MS Visual studio 2022 , .Net 07 ,


File Naming Shcema 


[Name] = I keep the same if they refer to same Data Model example My Data model is " Coffee " so everything related to Coffee will start with Coffee

[Name]+ Model = is a Model Data class
[Name]+ View = Content View Page .XAML
[Name]+ ViewModel = Code Behind C# that tell View what to do


Data Struckure 

[Service] Store something that will be used in multiple place !!! << update more when i understand>> or properly structure ..
[Models] Store all Model structure this should be same as table in SQLite or MS SQL and it name base on what it actualy store
[Views] Store all View page this is what it should look like on app aka UI
[ViewModels] Store all Code behind View Page this is where the magic happen ..


[Resource] this normal auto generate to store all other file like images and icon
[Platforms] this also auto generate i normal do not mesh with it at this time until i know what i need to do with it


-------- Do not mesh with this file ----



-- Nugget Package 

CommunityToolki.Mvvm
sqlite-net-pcl 
