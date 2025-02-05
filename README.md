<h1>Price Calculator App - .NET MAUI Exercise</h1>

#### Assignment 1 - PROG 10065

<a><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/cplusplus/cplusplus-original.svg" width="100"/></a>
<a><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/rider/rider-original.svg" width="100"/></a>
<a><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/dot-net/dot-net-plain-wordmark.svg" width="100"/></a>
<a><img src="https://cdn.jsdelivr.net/gh/devicons/devicon@latest/icons/git/git-plain-wordmark.svg" width="100"/></a>
          
          


          

Overview
--------

This small assignment is a **Price Calculator App** implemented in **.NET MAUI**, which allows users to input item prices, select discounts from a drop-down, and calculate the total price including tax. The exercise helped in understanding key .NET MAUI concepts such as data binding, event handling, UI components like `Picker`, and C# programming principles like encapsulation and property validation.

Concepts Learned & Showcased
----------------------------

### 1\. **.NET MAUI UI Components**

-   `Entry` for user input (name, price per item, number of items)

-   `Picker` for selecting a discount percentage

-   `RadioButton` to enable/disable discount application

-   `Button` to trigger discount calculation and clear data

-   `Label` for displaying calculated results

### 2\. **Event Handling in .NET MAUI**

-   Handling `Clicked` events for buttons to calculate and clear data

-   Handling `SelectedIndexChanged` for `Picker` to retrieve the selected discount

### 3\. **Data Validation in C#**

-   Ensured valid inputs for price per item and number of items (must be greater than zero)

-   Restricted discount values to between 0 and 1 (0-100%)

-   Implemented a default discount of 0 when none is applied

### 4\. **Encapsulation & Object-Oriented Programming (OOP)**

-   Created a `Bill` class to represent an item purchase

-   Encapsulated properties with validation logic

-   Applied constants (e.g., `taxRate = 0.13`) for maintaining fixed values

-   Used constructors to initialize bill data

Usage Instructions
------------------

1.  **Enter Name** - Provide a name in the `Entry` field

2.  **Enter Price Per Item** - Input a positive number

3.  **Select Discount** - Choose a percentage from the `Picker`

4.  **Enable Discount (Optional)** - Check the `RadioButton` if a discount should be applied

5.  **Enter Number of Items** - Input how many items are being purchased

6.  **Click "Discount" Button** - Calculate the total amount

7.  **Click "Clear" Button** - Reset all fields


Conclusion
----------

This project was a great learning exercise in .NET MAUI, covering UI controls, event-driven programming, data validation, and object-oriented principles in C#. 
