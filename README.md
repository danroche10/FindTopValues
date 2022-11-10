# Dan Roche FindTopValues test

## Design decisions

- I have created a class library so that it can be implemented into the main project containing the interface defined in the same namespace.
- I have assumed that the ```FindTopValues``` class requires no additional methods at this point.
- In terms of the additional requirement, I would take in account the Open-closed Principle which states "Objects or entities 
  should be open for extension but closed for modification". There I wouldn't modify the existing ```FindMaxValue``` method.
  I would instead create a new ```FindMaxValueBelow100``` method in the ```FindTopValues``` class which would also take 
  ```int [] anyOldValues``` as an argument. This method would then filter out the numbers above 100 and call the
  ```FindMaxValue``` method. It would pass in the filtered array as an argument.
- I'm more than happy to answer any further questions!
