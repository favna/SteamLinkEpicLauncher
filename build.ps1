
# Clean the entire build and output directories
Remove-Item -Force -Recurse -Path .\bin -ErrorAction Ignore
Remove-Item -Force -Recurse -Path .\obj -ErrorAction Ignore
Remove-Item -Force -Recurse -Path .\out -ErrorAction Ignore

# Publish to single exe
dotnet publish -r win10-x64 -p:PublishSingleFile=true -p:DebugType=None --self-contained true -c Release -o out
