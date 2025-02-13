import { useEffect, useState } from 'react';
import { feature, mesh } from 'topojson';
import { Topology } from "topojson-specification";
import { Marks } from './Marks';
import WorldAtlas from '../../models/WorldAtlas';
import getWorldAtlas from '../../api/worldAtlasClient';

const width = 960;
const height = 500;

export const WorldMap = () => {
    const [data, setData] = useState<WorldAtlas>();

    useEffect(() => {
        getWorldAtlas().then((topology: Topology) => {
        const { countries } = topology.objects;
        setData({
        countries: feature(topology, countries),
        interiors: mesh(topology, countries, (a, b) => a !== b)
        });
    });
    }, []);


  if (!data) {
    return <p>Loading...</p>;
  }

  return (
    <svg width={width} height={height}>
      <Marks data={data} />
    </svg>
  );
};

