Learning Basic C# with .Net Maui using MVVM and SQLite CRUD ( Create , Read , Update , Delete)

# About APP 

This should make windows and android version of app to add , read update and delete coffee database using MVVM toolkit and SQLite.
This is very basic app that i try to create base on what i learn from youtube and other website. I am appreacite if all expert come in help optimize and answer question if any a raise ..

## Requirement :

- MS Visual studio 2022 
- .Net 07 

## Nugget Package 

- CommunityToolki.Mvvm - V 8.2.0
- sqlite-net-pcl - V 1.8.116


### File Naming Shcema 


- [Name] = I keep the same if they refer to same Data Model example My Data model is " Coffee " so everything related to Coffee will start with Coffee

- [Name]+ Model = is a Model Data class
- [Name]+ View = Content View Page .XAML
- [Name]+ ViewModel = Code Behind C# that tell View what to do


### Data Struckure 

- [Service]
  - Store something that will be used in multiple place !!! << update more when i understand>> or properly structure ..
- [Models] 
  - Store all Model structure this should be same as table in SQLite or MS SQL and it name base on what it actualy store
- [Views] 
  - Store all View page this is what it should look like on app aka UI
- [ViewModels] 
  - Store all Code behind View Page this is where the magic happen.
	- Under this ViewModels folder there is a file < BaseViewModel.cs > this file contain all share information that other view models will be use .. so if anything that you think all your view models will be use put them in here ..


- [Resource] 
	- this normal auto generate to store all other file like images and icon
- [Platforms] 
	- this also auto generate i normal do not mesh with it at this time until i know what i need to do with it


## -- Do not mesh with this file --
	- ABC.cs
	- CBD.cs




## Credits -- i will update list with proper name and link 
	- Jame
	- John
	- Jamal

## images
	- images are generate use Easy Diffusion and Stable Diffusion Webui 
	- some images , icon , are default auto generate by MS Visual Studio


If any files or code or anything i use here belong to you and i forgot to credit please let me know i will glade to update and give credit too.