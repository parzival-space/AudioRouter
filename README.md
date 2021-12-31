<!-- ABOUT THE PROJECT -->

## About AudioRouter

By default, Windows will not allow you to use two (or more) output devices at the same time.
This is a problem for many people who want to play sounds from their speakers while they are using their headphones.

AudioRouter addresses this problem by copying the audio stream from the speakers to the headphones (or vice versa).
All this happens with almost no CPU impact (~0.1%).

### Built With

* [CommandLineParser](https://github.com/commandlineparser/commandline)
* [CSCore](https://github.com/filoe/cscore)
* [ILMerge](https://github.com/dotnet/ILMerge)
* [MSBuild.ILMerge.Task](https://dev.azure.com/Refactorius/MsBuild.ILMerge.Task)

## Preview

<p align="center">
  <img src="https://i.imgur.com/qEuFOY2.gif">
</p>

## Getting Started

As this tool was built using [CommandLineParser](https://github.com/commandlineparser/commandline), it has a built-in help command.
```
AudioRouter.exe help
```

You can get more detailed informations about the subcommands by using the `help` command.
```
AudioRouter.exe help <subcommand>
```

## License

Distributed under the GNU GPL v3.0 License. See `LICENSE` for more information.


## Known Issues

Anything listed here is known to be a bug.
It will be fixed as soon as possible.

<details>
  <summary>Changing any "Output"-Setting will result in feedback loops.</summary>

  - When you enable "Enhanced Audio" in the Windows Settings for the target device, while the device gets audio mirrored to, you will hear loud feedback on the device.
  - When you change the audio format of the target device, while the device gets audio mirrored to, you will hear loud feedback on the source device.Also the target device will no longer play audio.
  - When you change the "Spatial Audio" setting of the target device, while the device gets audio mirrored to, you will hear loud feedback on the source device.
  
  Changing any "Output"-Setting will result in feedback loops.
  Reverting to the previous setting will not fix the issue.
  A full restart of AudioRouter is required to fix the issue.

  <img src="https://i.imgur.com/DsWD3L9.png">
  <img src="https://i.imgur.com/zM7sc6q.png">
</details>

