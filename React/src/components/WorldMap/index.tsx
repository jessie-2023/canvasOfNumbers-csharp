import { useEffect, useState } from 'react';
import { feature, mesh } from 'topojson';
import { GeometryObject, Topology } from "topojson-specification";
import { FeatureCollection } from "geojson";
import { Marks } from './Marks';
import WorldAtlas from '../../models/WorldAtlas';
import getWorldAtlas from '../../api/worldAtlasClient';
import GapGeneral from '../../models/GapGeneral';
import { getGeneralByYear } from '../../api/backendClient';
import { scaleSequential } from 'd3-scale';
import { interpolateGnBu as colorGradience, max, min } from 'd3';



export const WorldMap = ({width, height, clickedYear, setSelectedCountry}) => {
    const [world, setWorld] = useState<WorldAtlas>();
    const [gaps, setGaps] = useState<GapGeneral[]>();
    
    useEffect(() => {
        getWorldAtlas().then((topology: Topology) => {
          const topoCountries = topology.objects.countries;
          setWorld({
            countries: feature(topology, topoCountries) as FeatureCollection, // transforms TopoJSON country data into a GeoJSON FeatureCollection
            interiors: mesh(topology, topoCountries as GeometryObject, (a, b) => a !== b) // extracts only the shared boundaries (like country borders) from a TopoJSON object
        })});
    }, []);

    useEffect(() => {
      getGeneralByYear(clickedYear)
        .then(data => setGaps(data))
    }, [clickedYear]);


  if (!world || !gaps || !gaps.length) {
    return <p>Loading...</p>;
  }

  const mapByCountry = new Map();
  gaps.forEach(country => mapByCountry.set(country.countryId, country)) 

  const colorValue = (gap: GapGeneral) => gap.generalGap; 
  const colorScale = scaleSequential(colorGradience).domain([ // swap min-max order can reverse the color gradience
    1,
    0.451 // promise min & max are NOT undefined
  ])
  
  return (
    <svg width={width} height={height}>
      <Marks 
        world={world} 
        mapByCountry={mapByCountry}
        colorScale={colorScale}
        colorValue={colorValue}
        setSelectedCountry={setSelectedCountry}
      />
    </svg>
  );
};

