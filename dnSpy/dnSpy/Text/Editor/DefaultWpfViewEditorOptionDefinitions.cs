﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.ComponentModel.Composition;
using dnSpy.Contracts.Text.Editor;
using dnSpy.Contracts.Text.Editor.Classification;

namespace dnSpy.Text.Editor {
	[Export(typeof(EditorOptionDefinition))]
	sealed class EnableHighlightCurrentLineEditorOptionDefinition : WpfViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultWpfViewOptions.EnableHighlightCurrentLineId;
		public override bool Default => false;
	}

	[Export(typeof(EditorOptionDefinition))]
	sealed class EnableMouseWheelZoomEditorOptionDefinition : WpfViewOptionDefinition<bool> {
		public override EditorOptionKey<bool> Key => DefaultWpfViewOptions.EnableMouseWheelZoomId;
		public override bool Default => true;
	}

	[Export(typeof(EditorOptionDefinition))]
	sealed class ZoomLevelEditorOptionDefinition : WpfViewOptionDefinition<double> {
		public override EditorOptionKey<double> Key => DefaultWpfViewOptions.ZoomLevelId;
		public override double Default => ZoomConstants.DefaultZoom;
		public override bool IsValid(ref double proposedValue) => ZoomConstants.MinZoom <= proposedValue && proposedValue <= ZoomConstants.MaxZoom;
	}

	[Export(typeof(EditorOptionDefinition))]
	sealed class AppearanceCategoryEditorOptionDefinition : WpfViewOptionDefinition<string> {
		public override EditorOptionKey<string> Key => DefaultWpfViewOptions.AppearanceCategory;
		public override string Default => AppearanceCategoryConstants.TextEditor;
		public override bool IsValid(ref string proposedValue) => !string.IsNullOrEmpty(proposedValue);
	}
}
