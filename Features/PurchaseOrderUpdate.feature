Feature: PurchaseOrderUpdate

 I want to update a purchase order
  So that I can submit my purchasing requirements

Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in

  @UpdatePurchaseOrder
  Scenario: Update a purchase order
    Given I click on Purchase order
    When I click on Action to edit order
    And I click on edit to edit order
    And I update the order title 
    And i update the order campany
    And i update the order devise
    And i update the order status
    And i update Consumption
    And i update Threshold
    And I click on Save button to update order
    Then the purchase order should be updated successfully
