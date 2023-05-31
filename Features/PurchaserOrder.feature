Feature: PurchaserOrder

 As a user
  I want to create a purchase request
  So that I can submit my purchasing order
Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in
 
  @createPurchaserOrder
  Scenario: Create a purchase order
    Given I click on purchase orders
    When I click on Create order
    And I enter the order title
    And I select the Campany 
    And I enter the Devise 
    And I select the status
    And I enter the Consumption
    And I enter the Threshold
    And I click on Save Order
    Then the purchaser order should be saved successfully
