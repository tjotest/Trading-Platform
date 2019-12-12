Feature: SearchOnPorts
 As a trader
 I want to search on Portname
 So that I can see information regarding the port
 
 Scenario: Search on Portname
  Given Trader is on port searchform
   When Portname is typed and enter is pressed
   Then results matcing the Portname is shown
  