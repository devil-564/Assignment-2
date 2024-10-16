Approach - My approach is basically to store the required content into a container by which processing the data would become easy and quick and then by applying certain condition we can get the required output.

Program Flow - 

      1. First create three dictionaries with key-value pair of type string and string 
      2. First Dictionary will store the name and password from sheet1(backupData), Second Dictionary will store the name and password from sheet2(currentData) and we will store result in thir Dictionary.
      3. After storing data, we need to iterate Dictionary-1 and apply condition that if name from dictionary 1 is present in Dictionary-2 if yes then their password is different then store the result in Result Dictionary.

Library Used - ClosedXML
