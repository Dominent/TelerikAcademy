@ECHO OFF

SET "FileInputName=Readme.md"
SET "FileOutputName=Readme.html"

pandoc %FileInputName% -f markdown -t html -s -o %FileOutputName%

