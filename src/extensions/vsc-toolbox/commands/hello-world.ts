// The module 'vscode' contains the VS Code extensibility API
// Import the module and reference it with the alias vscode in your code below
import * as vscode from 'vscode';

// This method is called when your extension is activated
// Your extension is activated the very first time the command is executed
export function activate(context: vscode.ExtensionContext) {
	console.log('Congratulations, your extension "toolbox" is now active!');

	// TODO: remove this and create a service for getting configurations in a more concrete way
	// this was only added so I remember how to get configurations in the future
	const configuration = vscode.workspace.getConfiguration('hazl.toolbox');
	const personalAccessToken = configuration.get<string | null>("hazl.toolbox.azure.devops.pat");
	console.log(personalAccessToken);
		
	const disposable = vscode.commands.registerCommand('toolbox.helloWorld', () => {
		vscode.window.showInformationMessage('Hello World from toolbox!');
	});

	context.subscriptions.push(disposable);
}

// This method is called when your extension is deactivated
export function deactivate() {}
