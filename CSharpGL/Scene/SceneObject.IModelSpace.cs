﻿using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace CSharpGL
{
    public partial class SceneObject
    {
        #region IModelSpace

        /// <summary>
        /// Position in world space.
        /// </summary>
        [Category(strSceneObject)]
        [Description("Position in world space.")]
        public vec3 WorldPosition
        {
            get
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { return renderer.WorldPosition; }
                else { return new vec3(0, 0, 0); }
            }
            set
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { renderer.WorldPosition = value; }
                else { throw new Exception(string.Format("No renderer for this scene object!")); }
            }
        }

        /// <summary>
        /// Rotation angle in degree.
        /// </summary>
        [Category(strSceneObject)]
        [Description("Rotation angle in degree.")]
        public float RotationAngleDegree
        {
            get
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { return renderer.RotationAngleDegree; }
                else { return 0.0f; }
            }
            set
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { renderer.RotationAngleDegree = value; }
                else { throw new Exception(string.Format("No renderer for this scene object!")); }
            }
        }

        /// <summary>
        /// Rotation axis.
        /// </summary>
        [Category(strSceneObject)]
        [Description("Rotation axis.")]
        public vec3 RotationAxis
        {
            get
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { return renderer.RotationAxis; }
                else { return new vec3(0, 0, 0); }
            }
            set
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { renderer.RotationAxis = value; }
                else { throw new Exception(string.Format("No renderer for this scene object!")); }
            }
        }

        /// <summary>
        /// Scale factor.
        /// </summary>
        [Category(strSceneObject)]
        [Description("Scale factor.")]
        public vec3 Scale
        {
            get
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { return renderer.Scale; }
                else { return new vec3(1, 1, 1); }
            }
            set
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { renderer.Scale = value; }
                else { throw new Exception(string.Format("No renderer for this scene object!")); }
            }
        }

        /// <summary>
        /// Length in X/Y/Z axis.
        /// </summary>
        [Category(strSceneObject)]
        [Description("Length in X/Y/Z axis.")]
        public vec3 Lengths
        {
            get
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { return renderer.Lengths; }
                else { return new vec3(0, 0, 0); }
            }
            set
            {
                RendererBase renderer = this.renderer;
                if (renderer != null) { renderer.Lengths = value; }
                else { throw new Exception(string.Format("No renderer for this scene object!")); }
            }
        }

        #endregion IModelSpace
    }
}