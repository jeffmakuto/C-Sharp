#!/usr/bin/env bash

# Run the complied C# program
dotnet run

# Check the return value using $?
if [ $? -eq 0 ]; then
	echo "Execution succeeded"
else
	echo "Execution failed"

fi

# Display return value
echo "Return value = $?"
