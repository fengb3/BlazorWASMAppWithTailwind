using Microsoft.AspNetCore.Components;

namespace BlazorWASMAppWithTailwind.Pages;

public partial class Button : ComponentBase
{
	[Parameter] public string? Title { get; set; }

	[Parameter]
	public Type? ButtonType { get; set; } = Type.Primary;
	
	
	public enum Type
	{
		Primary,
		Danger,
	}
}