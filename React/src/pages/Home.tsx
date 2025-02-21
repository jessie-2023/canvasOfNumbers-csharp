import { useEffect, useState } from "react";
import Country from "../models/Country";
import Gap from "../models/Gap";
import Region from "../models/Region";
import { WorldMap } from "../components/WorldMap/index";
import { TrendBar } from "../components/TrendBar";

const width = 960;
const height = 500;
const mapShare = 0.75;
const barShare = 0.4;

export default function Home()
{
    const [clickedCountry, setClickedCountry] = useState<number>(352);   
    const [clickedYear, setClickedYear] = useState<number>(2019);
    
    return (
        <svg width={width} height={height}>
            <g transform={`scale(${mapShare}) translate(${(1 - mapShare) * width / 2}, 0)`}>
                <WorldMap 
                    width={width}
                    height={height}
                    clickedYear={clickedYear}
                    setSelectedCountry={setClickedCountry}
                />
            </g>
            <g transform={`translate(0, ${height - barShare * height})`}>
                <TrendBar 
                    width={width}
                    height={barShare * height}
                    selectedCountry={clickedCountry}
                    setClickedYear={setClickedYear}
                />
            </g>
        </svg>
            
    )
}