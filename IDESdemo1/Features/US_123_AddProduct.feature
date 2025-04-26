Feature: US_123_AddProduct

As a user 
I would like to be able to add a product
So I can put my pruduct in the system

"""
Doc
=====
Author: Jimmy Riguelle

"""

# Ceci est un commentaire

@TFS_123
Scenario: Validate that I can reach the page add product
	Given User is the landing page
	When I click on addProduct
	Then I should reach the page add product 

@TFS_456
Scenario: Validate that I can add product check input Name
	Given Landing on add product page
	When I fill product name
	Then I should able to add the product name 

@TFS_789
Scenario: Validate that I can add product check input Price
	Given Landing on add product page
	When I fill product price
	Then I should able to add the product price 
