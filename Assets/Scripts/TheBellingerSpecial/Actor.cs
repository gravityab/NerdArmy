﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NerdArmy;

/// <summary>
/// The unity representation of a unit in combat or a mission. This information
/// represents temporary status.
/// </summary>
public class Actor
{
    /// <summary>
    /// The Unit information. Use UnitFactor.Create() a cutout UnitType.
    /// </summary>
    private Unit _unit = null;
    public Unit unit
    {
        get { return _unit; }
        set { _unit = value; }
    }

    /// <summary>
    /// The owner of unit to be controlled in a mission.
    /// </summary>
    private Owner _owner = Owner.NONE;
    public Owner owner
    {
        get { return _owner; }
        set { _owner = value; }
    }

    /// <summary>
    /// The current health of the unit in the mission. Set to maxHp at mission
    /// start.
    /// </summary>
    private int _health = 0;
    public int health
    {
        get { return _health; }
        set { _health = value; }
    }

    /// <summary>
    /// Unit positional information.
    /// </summary>
    private Vector2 _position = Vector2.zero;
    public Vector2 position
    {
        get { return _position; }
        set
        {
            if (_renderer == null)
                _renderer = new TileRenderer(_position.x, _position.y);
            _renderer.SetPosition(_position.x, _position.y);
            _position = value;
        }
    }

    /// <summary>
    /// The renderer for the tile.
    /// </summary>
    private TileRenderer _renderer = null;
    public TileRenderer renderer
    {
        get { return _renderer; }
        set { _renderer = value; }
    }
}
