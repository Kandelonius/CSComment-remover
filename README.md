# Comment Remover

#### Program will read the clipboard and if there is text it will go line by line and 'remove' each line which has been commented out by checking if the first two characters are '//'. I want the function to be idempotent and to not change the contents of the clipboard, so the user would be able to still paste the original unaltered text.
