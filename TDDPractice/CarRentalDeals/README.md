# Playing Banjo!

### What does the program do?

    The aim of this program is to calculate how much you would save given a number of days a person wants to rent a car.

    For rentals 1 or 2 days, there is no discount.
    For rentals 3 to 6 days, the discount is £20.
    For rentals 7 days or more, the discount is £50.

#### Prices Table (£)

| Days | Original | Final   | Discount |
| ---- | -------- | ------- | -------- |
| 1    | 40       | 40      | -        |
| 2    | 80       | 80      | -        |
| 3-6  | 120-240  | 100-220 | 20       |
| 7+   | 280+     | 230+    | 50       |

### What was the development approach?

    I am using test driven development. My aim is to right failing tests, making them pass then refactoring the code.
