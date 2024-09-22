Feature: Youtube search feature

search for anythink

@tag1
Scenario: Control of elemnts on the home page.
	Given User open the browser
	When User enter the url "<url>"
	Then User clicks three line menü button.
	Then User should see these buttons; MainPage, Shorts, Subscriptions, You, History.
Examples: 
	| url                                        | 
	| https://www.youtube.com/?app=desktop&hl=tr | 

@tag1
Scenario: Search for anyvideo
	Given User open the browser
	When User enter the url "<url>"
	Then User click search area and search for the "<searched item>" then click search button.
	Then User click x button in the search textbox.
Examples: 
	| url                                        | searched item     |
	| https://www.youtube.com/?app=desktop&hl=tr | What is selenium? |


