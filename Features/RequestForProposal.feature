Feature: RequestForProposal

 As a user
  I want to create a purchase request
  So that I can submit my purchasing requirements
Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in
 
  @createProposal
  Scenario: Create a proposal request
    Given I click on proposal Requests
    When I click on Create proposal
    And I enter the proposal title
    And I select the categorie 
    And I enter the submission 
    And I enter the deadLine
    And I check the status checkbox
    And I click on Save 
    Then the proposal request should be saved successfully
