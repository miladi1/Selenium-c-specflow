Feature: RequestForProposalUpdate

 As a user
  I want to update a proposal request
  So that I can submit my propsaling requirements

Background: Authenticate
    Given I am on the login page
    When I enter my email and password
    And I click the login button
    Then I should be logged in

  @UpdateProposal
  Scenario: Update a proposal request
    Given I click on Prop Request
    When I click on Action to edit
    And I click on edit button
    And I update title 
    And I update submission
    And i update categorie
    And i update deadline
    And i update status
    And I click on Save to to update
    Then the proposal request should be updated successfully
