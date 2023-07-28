<div align="center">
    <h1>Sudo</h1>

    Linux's sudo command now for Windows.
</div>
<div align="center">
    <table>
        <tr>
            <th>Contents</th>
            <th>Links</th>
        </tr>
        <tr>
            <td>Installation</td>
            <td>
                <a href="#installation">Go</a>
            </td>
        </tr>
        <tr>
            <td>How to Use</td>
            <td>
                <a href="#usage">Go</a>
            </td>
        </tr>
        <tr>
            <td>Build from Source</td>
            <td>
                <a href="#build-from-source">Go</a>
            </td>
        </tr>
        <tr>
            <td>License</td>
            <td>
                <a href="#license">Go</a>
            </td>
        </tr>
    </table>
</div>

## Installation
<h3 style="display: inline;">First</h3>, download the "<code>windows-sudo</code>" zip file from the release you're planning to use.

Once you've downloaded the file, unzip it. After, you should see a folder with the `.exe` file inside.

To complete the installation, you could add the unzipped folder to your `path`.

## Usage
> <!> If you haven't installed the program, please follow the [installation](#installation) guide first.

The program is very easy to use and once installed it can be used right away.

```bash
sudo [options] <program>
```
That's the structure the program expects you to pass in arguments.

To see available options, pass `--help` as an option.

## Build from Source

<h3 style="display:inline;">First</h3>, make sure you have .NET installed.

`.NET 6.0.302` was used for this project.

If you have `git`, you can `git clone` this repository.
```shell
git clone repo-link
```
Or you could simply download the source code as a zip and unzip it.

<h3 style="display:inline;">Then</h3>, navigate to the cloned or downloaded folder and run:

```shell
dotnet build --configuration Release
```
It *should* compile the solution automatically, if it doesn't work, try specifying the solution explicitly:
```shell
dotnet build SudoCommand.sln --configuration Release
```

> These commands will compile the project in Release mode. If you need it, you can also compile in Debug mode by removing `--configuration Release` from the options.

Once done, the build should compile successfully and you'll see the executable in `sudo/bin/Release/net6.0/`.

# License
 This project is licensed under the Attribution-NonCommercial-NoDerivatives 4.0 International license.
 
 <a rel="license" href="http://creativecommons.org/licenses/by-nc-nd/4.0/"><img alt="Creative Commons License" style="border-width:0" src="https://i.creativecommons.org/l/by-nc-nd/4.0/88x31.png" /></a><br />This work is licensed under a <a rel="license" href="http://creativecommons.org/licenses/by-nc-nd/4.0/">Creative Commons Attribution-NonCommercial-NoDerivatives 4.0 International License</a>