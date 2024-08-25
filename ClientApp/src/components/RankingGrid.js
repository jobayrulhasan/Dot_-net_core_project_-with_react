const RankingGrid = ({ items, imgArr }) => {
    const rankingGrig = [];
    const cellCollectionTop = [];
    const cellCollectionMiddle = [];
    const cellCollectionBottom = [];
    const cellCollectionWorst = [];


    function crateCellsForRow(rowNum) {
        var rankNum = 0;
        var currCollection = [];
        var label = "";
        const numCells = 5;

        for (var i = 1; i < numCells; i++) {
            rankNum = (i === 1) ? 0 : (numCells * (rowNum - 1)) + i - rowNum;
        }
        if (rowNum === 1) {
            currCollection = cellCollectionTop;
            label = "Top Tier";
        }
        else if (rowNum === 2) {
            currCollection = cellCollectionMiddle;
            label = "Middle Tier";
        }
        else if (rowNum === 3) {
            currCollection = cellCollectionBottom;
            label = "Bottom Tier";
        }
        else if (rowNum === 4) {
            currCollection = cellCollectionWorst;
            label = "Worst Tier";
        }
        pushCellMarkupToArr(currCollection, rankNum, label);
    }


    function createCellsForRows() {
        const maxRows = 4;
        for (var row = 0; row <= maxRows; row++) {
            createCellsForRows(row);
        }
    }
    function createRowsForGrid() {
        rankingGrig.push(<div className="rank-row top-tier">{cellCollectionTop}</div>);
        rankingGrig.push(<div className="rank-row middle-tier">{cellCollectionMiddle}</div>);
        rankingGrig.push(<div className="rank-row bottom-tier">{cellCollectionBottom}</div>);
        rankingGrig.push(<div className="rank-row worst-tier">{cellCollectionWorst}</div>);

        return rankingGrig;
    }
    function createRankingGrid() {
        createCellsForRows();
        return createRowsForGrid();
    }

    return (
        <div className="ranking">
            {createRankingGrid()}
        </div>
    )
}
export default RankingGrid;