# mauiAotProblem

Show the System.ExecutionEngineException "Attempting to JIT compile method xxx while running in aot-only mode." on ios release mode.
Make sure to run it on a real device since the simulator does not have the same AOT compiler.

Run the application and press on the "Automap" button... you should see an exception in the label at the bottom.

Same or similar as https://github.com/xamarin/xamarin-macios/issues/12416
