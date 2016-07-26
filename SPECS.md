## Specifications
### Primary Specifications
| Behavior        | Input           | Outcome  |
| ------------- |:-------------:| -----:|
| Return match amount of 1 for matching one word inputs of phrase and word to search by | Phrase: "what", Word: "what" | 1 match |
| Return match amount of 0 for differing one word inputs of phrase and word to search by  | Phrase: "no", Word: "dice" | 0 matches |
| Return match amount of 2 for matching two-word inputs of phrase and single word to search by | Phrase: "yolo yolo", Word "yolo" | 2 matches |
| Return match amount of 3 for matching three-word inputs of phrase and solitary word to search by | Phrase: "yolo yolo yolo", Word "yolo" | 3 matches |
| Return match amount of 1 for singularly matching word inputs of phrase and word to search by | Phrase: "yolo bro", Word "bro" | 1 match |
| Return match amount of 1 for matching words with mismatched capitalization | Phrase: "Howdy", Word: "howdy" | 1 match |
| Return match amount of 1 for matching words with mismatched puncuation | Phrase: "Howdy!". Word: "howdy" | 1 match |
| Return match amount of zero for mismatching words where one word is contained in the other | Phrase: "Catcher" | 1 match |
| When full sentence or paragraph and specific words are received as input, determines how many times the specific word occurs in full string. | "I got a dog because there was a dog at the dog pound." | The word "dog" occurs 3 times. |
